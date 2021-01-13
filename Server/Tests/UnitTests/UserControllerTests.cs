using BlazorCms.Server.Controllers;
using MediatR;
using Microsoft.Extensions.Logging;
using Xunit;

namespace Server.Tests.UnitTests
{
    public class UserControllerTests
    {
        private readonly UserController _sut;
        private readonly IMediator _imediator;
        private readonly ILogger<UserControllerTests> _logger;

        public UserControllerTests()
        {
            
        }

        [Fact]
        public void TestName()
        {
        //Given
        
        //When
        
        //Then
        }
    }
}