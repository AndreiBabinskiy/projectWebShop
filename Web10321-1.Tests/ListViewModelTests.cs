using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using web1_1.DAL.Entities;
using web1_1.Models;
using Xunit;

namespace Web10321_1.Tests
{
    public class ListViewModelTests
    {
        [Fact]
        public void ListViewModelCountsPages()
        {
            // Act
            var model = ListViewModel<Wheelchair>.GetModel(TestData.GetDishesList(), 1, 3);

            // Assert
            Assert.Equal(2, model.TotalPages);
        }
        [Theory]
        [MemberData(memberName: nameof(TestData.Params),
        MemberType = typeof(TestData))]

        public void ListViewModelSelectsCorrectQty(int page, int qty, int id)
        {
            // Act
            var model = ListViewModel<Wheelchair>.GetModel(TestData.GetDishesList(), page, 3);

            // Assert
            Assert.Equal(qty, model.Count);
        }

        [Theory]
        [MemberData(memberName: nameof(TestData.Params), MemberType = typeof(TestData))]

        public void ListViewModelHasCorrectData(int page, int qty, int id)
        {
            // Act
            var model = ListViewModel<Wheelchair>.GetModel(TestData.GetDishesList(), page, 3);

            // Assert
            Assert.Equal(id, model[0].WheelchairId);
        }
    }
}
