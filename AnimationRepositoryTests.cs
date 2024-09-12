using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace UnitTestPractice;

public class AnimationRepositoryTests
{

    private AppDbContext GetInMemoryDbContext()
    {
        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;
        return new AppDbContext(options);
    }
    
    [Fact]
    public async Task AddAnimationAsync_ShouldAddAnimation()
    {
        var context = GetInMemoryDbContext();
        var repository = new AnimationRepository(context);
        var animation = new Animation() { Name = "TestAnimation" };

        await repository.AddAnimationAsync(animation);

        Assert.Equal(1, context.Animations.Count());
        Assert.Equal("TestAnimation", context.Animations.First().Name);

    }

    [Fact]

    public async Task GetAnimationsByIdAsync_ShouldReturnAnimation()
    {
        var context = GetInMemoryDbContext();
        var repository = new AnimationRepository(context);
        var animation = new Animation { Name = "TestAnimation" };

        await repository.AddAnimationAsync(animation);

        var result = await repository.GetAnimationByIdAsync(animation.Id);

        Assert.NotNull(result);
        Assert.Equal("TestAnimation", result.Name);
    }

    [Fact]
    public async Task GetAllAnimationsAsync_ShouldReturnAllAnimations()
    {
        var context = GetInMemoryDbContext();
        var repository = new AnimationRepository(context);
        await repository.AddAnimationAsync(new Animation { Name = "Animation1" });
        await repository.AddAnimationAsync(new Animation { Name = "Animation2" });

        var result = await repository.GetAllAnimationsAsync();
            
        Assert.Equal(2, result.Count());
    }

    [Fact]
    public async Task UpdateAnimationAsync_ShouldUpdateAnimation()
    {
        var context = GetInMemoryDbContext();
        var repository = new AnimationRepository(context);
        var animation = new Animation { Name = "OldName" };
        await repository.AddAnimationAsync(animation);

        animation.Name = "NewName";
        await repository.UpdateAnimationAsync(animation);

        var updatedAnimation = await repository.GetAnimationByIdAsync(animation.Id);
        Assert.Equal("NewName", updatedAnimation.Name);
    }

    [Fact]
    public async Task DeleteItemAsync_ShouldRemoveItem()
    {
        var context = GetInMemoryDbContext();
        var repository = new AnimationRepository(context);
        var animation = new Animation { Name = "TestAnimation" };
        await repository.AddAnimationAsync(animation);

        await repository.DeleteAnimationAsync(animation.Id);
        
        Assert.Equal(0, context.Animations.Count());
    }
}

