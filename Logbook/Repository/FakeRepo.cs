using Logbook.Models;

namespace Logbook.Repository;


public class FakeRepo
{
    public static List<Student> GetStudents()
    {
        return new()
        {
            new(1, "avatar2.png", "Leyla", "Shefiyeva", "Dursun", new DateTime(2022, 10, 3), ParticipationStatus.Unknown, null, null, null, null),
            new(2, null, "Miri", "Huseynzade", "Ziya", new DateTime(2022, 10, 4), ParticipationStatus.Absent, null, null, null, null),
            new(3, "avatar1.png", "Ali", "Shamilzade", "Azer", new DateTime(2022, 10, 6), ParticipationStatus.Late, null, null, null, null),
            new(4, "avatar1.png", "Huseyn", "Ibrahimov", "Allahverdi", new DateTime(2022, 10, 5), ParticipationStatus.Absent, null, null, null, null),
            new(5, null, "Tural", "Hacinebili", "Mahir", new DateTime(2022, 10, 5), ParticipationStatus.Absent, null, null, null, null),
            new(6, null, "Kenan", "Muradov", "Arif", new DateTime(2022, 10, 6), ParticipationStatus.Present, null, null, null, null),
            new(7, null, "Nihat", "Ekremi", "Celal", new DateTime(2022, 10, 7), ParticipationStatus.Present, null, null, null, null),
            new(8, null, "Murad", "Meherremli", "Yusif", new DateTime(2022, 10, 8), ParticipationStatus.Late, null, null, null, null)
        };
    }
}