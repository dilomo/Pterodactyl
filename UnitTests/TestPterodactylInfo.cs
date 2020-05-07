using System;
using Pterodactyl;
using UnitTests;
using Xunit;

namespace UnitTests
{
    public class TestPterodactylInfoHelper
    {
        public static PterodactylInfo TestObject
        {
            get
            {
                PterodactylInfo testObject = new PterodactylInfo();
                return testObject;
            }
        }
    }


    public class TestPterodactylInfo
    {
        [Fact]
        public void TestName()
        {
            string expected = "Pterodactyl";
            string actual = TestPterodactylInfoHelper.TestObject.Name;

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestDescription()
        {
            string expected = "Pterodactyl will help you to create reports";
            string actual = TestPterodactylInfoHelper.TestObject.Description;

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestId()
        {
            System.Guid expected = new Guid("136fc04c-dbc3-4b83-a736-d15c893b21ca");
            System.Guid actual = TestPterodactylInfoHelper.TestObject.Id;

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestAuthorName()
        {
            string expected = "Wojciech Radaczynski";
            string actual = TestPterodactylInfoHelper.TestObject.AuthorName;

            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestAuthorContact()
        {
            string expected = "w.radaczynski@gmail.com";
            string actual = TestPterodactylInfoHelper.TestObject.AuthorContact;

            Assert.Equal(expected, actual);
        }
    }
}
