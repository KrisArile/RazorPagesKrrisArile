using Microsoft.EntityFrameworkCore;
using RazorPagesKrrisArile.Data;

namespace RazorPagesKrrisArile.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesKrrisArileContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesKrrisArileContext>>()))
            {
                if (context == null || context.Sheet == null)
                {
                    throw new ArgumentNullException("Null RazorPagesKrrisArileContext ");
                }
                if (context.Sheet.Any())
                {
                    return;
                }

            }
        }
    }
}
