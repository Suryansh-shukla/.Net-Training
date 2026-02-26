using System;
using System.Text;
public class ErrorLoggingMiddleware
{
    private readonly RequestDelegate _next;
    private readonly string _logFilePath = "Logs/errorlog.txt";

    public ErrorLoggingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            await LogError(context,ex);
            context.Response.StatusCode = 500;
            await context.Response.WriteAsync("An unexpected error occurred. Please try again later.");
        }
    }
    public async Task LogError(HttpContext context, Exception ex)
    {
        Directory.CreateDirectory("Logs");
        var logMessage = new StringBuilder();
        logMessage.AppendLine("====Error Start====");
        logMessage.AppendLine($"Time: {DateTime.Now}");
        logMessage.AppendLine($" Path: {context.Request.Path}");
        logMessage.AppendLine($"Method: {context.Request.Method}");
        logMessage.AppendLine($" Message: {ex.Message}");
        logMessage.AppendLine($"Stack Trace: {ex.StackTrace}");
        logMessage.AppendLine(new string('-', 50));

        var logFilePath = Path.Combine("Logs", "errorlog.txt");
        await File.AppendAllTextAsync(logFilePath, logMessage.ToString());
    }
}