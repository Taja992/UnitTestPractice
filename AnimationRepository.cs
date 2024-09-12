using Microsoft.EntityFrameworkCore;

namespace UnitTestPractice;

public class AnimationRepository : IAnimationRepository
{
    private readonly AppDbContext _context;

    public AnimationRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Animation> GetAnimationByIdAsync(int id)
    
    {
        return await _context.Animations.FindAsync(id);
    }

    public async Task<IEnumerable<Animation>> GetAllAnimationsAsync()
    {
        return await _context.Animations.ToListAsync();
    }

    public async Task AddAnimationAsync(Animation animation)
    {
        await _context.Animations.AddAsync(animation);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAnimationAsync(Animation animation)
    {
        _context.Animations.Update(animation);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAnimationAsync(int id)
    {
        var animation = await _context.Animations.FindAsync(id);
        if (animation != null)
        {
            _context.Animations.Remove(animation);
            await _context.SaveChangesAsync();
        }
    }


}