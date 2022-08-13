// 

internal static class DateUtil
{
    public static int YearOfBirth(int Age)
    {
        return DateTime.Now.Year - Age;
    }

    public static int YearOfBirth(DateTime dateOfBirth)
    {
        if (dateOfBirth == null)
            return 0;
        return dateOfBirth.Year;
    }

    public static int Age(DateTime dateOfBirth)
    {
        if (dateOfBirth == null)
            return 0;
        return DateTime.Now.Year - dateOfBirth.Year;
    }
}