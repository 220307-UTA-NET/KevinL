namespace MyFirstServer.Middleware
{
    public class RequireAuthorization
    {
        private readonly RequestDelegate _next;
        public RequireAuthorization(RequestDelegate next)
        {
            this._next = next; 
        }
        public async Task InvokeAsync(HttpContext context)
        {
            if (context.Request.Query["authorization"] == "true")
            {
                // "yeah,you're good. let the whatever is next on the request pipeline deal with this"
                await _next(context);
            }
            else
            {
                // if we don't have authorization... then what?
                context.Response.StatusCode = 401;
                context.Response.ContentType = "text/plain";
                await context.Response.WriteAsync("error! not authorized");
            }
        }

    }
}
