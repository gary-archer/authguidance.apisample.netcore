namespace SampleApi.Plumbing.Claims
{
    /*
     * A simple holder class that is request scoped and updated with claims at runtime
     */
    public class ClaimsHolder
    {
        public ApiClaims Value { get; set; }
    }
}
