namespace UnitTestPractice;

public interface IAnimationRepository

{
    Task<Animation> GetAnimationByIdAsync(int id);
    Task<IEnumerable<Animation>> GetAllAnimationsAsync();
    Task AddAnimationAsync(Animation animation);
    Task UpdateAnimationAsync(Animation animation);
    Task DeleteAnimationAsync(int id);
}