namespace LeetCode.UnitTests;

public class DistanceBetweenBusStopsTests
{
    [Fact]
    public void DistanceBetweenBusStops_SimpleClockWiseIncreamentalStartFrom0_ReturnShortestWay()
    {
        
        // Arrange
        int [] distance = [1,2,3,4];
        int start = 0;
        int distination = 2;

        int expected = 3;

        // Act
        int result = ShortestPathInCircle.DistanceBetweenBusStops(distance, start, distination);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void DistanceBetweenBusStops_SimpleIncreamentalClockWiseStartFrom0_ReturnShortestWay()
    {
        
        // Arrange
        int [] distance = [1,2,3,4];
        int start = 0;
        int distination = 1;

        int expected = 1;

        // Act
        int result = ShortestPathInCircle.DistanceBetweenBusStops(distance, start, distination);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void DistanceBetweenBusStops_DisorderedStartFromMiddle_ReturnShortestWay()
    {
        
        // Arrange
        int [] distance = [7,10,1,12,11,14,5,0];
        int start = 7;
        int distination = 2;

        int expected = 17;

        // Act
        int result = ShortestPathInCircle.DistanceBetweenBusStops(distance, start, distination);
        Assert.Equal(expected, result);
    }
}