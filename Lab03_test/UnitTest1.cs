using Lab03_class;

namespace Lab03_test;

public class UnitTest1
{
    [Fact]
    public void Add()
    {
        List<int> data = new List<int>{9, 4, 3, 1};

        IPriorityQueue<int> data2 = new PriorityQueue<int>();
        data2.Add(1);
        data2.Add(3);
        data2.Add(9);
        data2.Add(4);

        Assert.Equal(data, data2);
    }
    
    [Fact]
    public void Peek()
    {
        IPriorityQueue<int> data = new PriorityQueue<int>();
        
        data.Add(1);
        data.Add(9);
        data.Add(2);
        data.Add(4);

        int actual = data.Peek();
        
        Assert.Equal(9, actual);
    }
    
    [Fact]
    public void Remove()
    {
        List<int> data = new List<int>{4, 2, 1};
        
        IPriorityQueue<int> data2 = new PriorityQueue<int>();
        
        data2.Add(1);
        data2.Add(9);
        data2.Add(2);
        data2.Add(4);
        
        int actual = data2.Remove();
        
        Assert.Equal(9, actual);
        Assert.Equal(data, data2);
    }
}