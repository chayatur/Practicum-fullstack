namespace MatchMaking.Api.Middlewares
{
    public class ShabbatMiddleware
    {
        private readonly RequestDelegate next;

        public ShabbatMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Saturday)
            {
                context.Response.StatusCode = 400;
                return;
            }

            await next(context);
        }
    }
}
