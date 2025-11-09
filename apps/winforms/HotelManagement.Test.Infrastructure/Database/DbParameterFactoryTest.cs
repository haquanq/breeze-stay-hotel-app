using HotelManagement.Infrastructure.Attributes;
using HotelManagement.Infrastructure.Database;

namespace HotelManagement.Test.Infrastructure.Database
{
    public class DbParameterFactoryTest
    {

        internal enum TestEnum
        {
            HELLO
        }

        internal class TestUser
        {
            [DbMapping("some_name")]
            public TestEnum Value { get; set; }
        }

        private readonly IDbParameterFactory _factory = new DbParameterFactory();

        [Fact]
        public void Has_DbMappingAttribute()
        {
            var property = typeof(TestUser).GetProperty("Value");
            Assert.True(property != null);

            var attributeList = property.GetCustomAttributes(typeof(DbMappingAttribute), true);
            Assert.True(attributeList.Length != 0);

            var name = attributeList.Cast<DbMappingAttribute>().Single().Name;
            Assert.Equal("some_name", name);
        }

        [Fact]
        public void Cook_EnumValueToString()
        {
            var user = new TestUser()
            {
                Value = TestEnum.HELLO
            };

            Assert.IsAssignableFrom<Enum>(user.Value);
            Assert.IsType<TestEnum>(user.Value);

            var cooked = _factory.Create(user);

            Assert.True(cooked.ContainsKey("some_name"));
            Assert.IsType<string>(cooked["some_name"]);
            Assert.Equal(TestEnum.HELLO.ToString(), cooked["some_name"]);
        }
    }
}