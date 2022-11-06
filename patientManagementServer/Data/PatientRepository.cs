using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace patientManagementServer.Data
{
    public class PatientRepository
    {
        internal async static Task<List<Patient>> GetPatientsAsync(string sortBy, string direction, string? town, string? firstname, string? lastname, string? patientsex, int? offset, int? limit)
        {
            using (var db = new AppDBContext())
            {
                Dictionary<string, Expression<Func<Patient, object>>> sortDict = new Dictionary<string, Expression<Func<Patient,object>>> {
                    { "firstname", p => p.firstname },
                    { "lastname", p => p.firstname },
                    { "dob", p => p.dob },
                    { "patientsex", p => p.patientsex },
                    { "email", p => p.email },
                    { "town", p => p.town }
                };

                if(direction == "DESC")
                    return await db.Patients
                            .Where(p =>
                                p.town.Contains(town ?? "")
                                && p.firstname.Contains(firstname ?? "")
                                && p.lastname.Contains(lastname ?? "")
                                && p.patientsex.Contains(patientsex ?? ""))
                            .OrderByDescending(sortDict[sortBy] ?? sortDict["firstname"])  // descending here
                            .Skip(offset ?? 0).Take(limit ?? -1)
                            .ToListAsync();

                return await db.Patients
                        .Where(p =>
                            p.town.Contains(town ?? "")
                            && p.firstname.Contains(firstname ?? "")
                            && p.lastname.Contains(lastname ?? "")
                            && p.patientsex.Contains(patientsex ?? ""))
                        .OrderBy(sortDict[sortBy]?? sortDict["firstname"])
                        .Skip(offset ?? 0).Take(limit ?? -1)
                        .ToListAsync();
            }
        }

        internal async static Task<bool> CreatePatientAsync(Patient patientToCreate)
        {
            using(var db = new AppDBContext())
            {
                try
                {
                    await db.Patients.AddAsync(patientToCreate);

                    return await db.SaveChangesAsync() >= 1;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }
    }
}
