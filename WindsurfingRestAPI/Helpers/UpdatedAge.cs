namespace WindsurfingRestAPI.Helpers
{
    public static class UpdatedAge
    {
        public static int GetCurrentAge(this DateTimeOffset dateTimeOffset)
        {
            //this word changed everything 
            var currentdate = DateTime.UtcNow; 
            int age = currentdate.Year- dateTimeOffset.Year;
            //this little condition to check if there is an error when passing the date 
            if (currentdate < dateTimeOffset.AddYears(age))
            {
                age--;
            }

            return age; 
        }
    }
}
