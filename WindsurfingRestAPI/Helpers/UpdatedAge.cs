namespace WindsurfingRestAPI.Helpers
{
    public static class UpdatedAge
    {
        public static int GetCurrentAge(this DateTime notanymoredateTimeOffset)
        {
            //this word changed everything 
            var currentdate = DateTime.UtcNow; 
            int age = currentdate.Year- notanymoredateTimeOffset.Year;
            //this little condition to check if there is an error when passing the date 
            if (currentdate < notanymoredateTimeOffset.AddYears(age))
            {
                age--;
            }

            return age; 
        }
    }
}
