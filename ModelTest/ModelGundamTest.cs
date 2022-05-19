using ModelGundam;
using Xunit;

namespace ModelTest
{
    public class ModelGundamTest
    {
        //This is how C#/Xunit recognizes that this particular method will be a unit test
        //Data annotation -  They just add special metadata information that gives special properties to a particulat class member
        [Fact]
        public void ModelID_Should_Set_Valid_Data()
        {
            //Arrange
            Model modelObj = new Model();
            int modelID = 28;

            //Act
            modelObj.ModelID = modelID;

            //Assert
            Assert.NotNull(modelObj.ModelID);
            Assert.Equal(modelID, modelObj.ModelID);
        }

        [Fact]
        public void ModelID_Should_Fail_Set_InvalidData()
        {
            Model modelObj = new Model();
            int modelID = -19;

            Assert.Throws<System.ComponentModel.DataAnnotations.ValidationException>(() => 
                {
                    modelObj.ModelID = modelID;
                    
                }
            );
            
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-19)]
        [InlineData(-1290)]
        [InlineData(-12983)]
        public void ModelID_Should_Fail_If_Set_InvalidData(int m_modelID)
        {
            Model modelObj = new Model();

            Assert.Throws<System.ComponentModel.DataAnnotations.ValidationException>(() =>
                {
                    modelObj.ModelID = m_modelID;
                }
            
            );
        }
    }

}