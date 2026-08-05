using System.Diagnostics.Tracing;

public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1
        if(value == Data) 
        {                   
            return;      //<-- nothing happend
        }

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {   
        

        // TODO Start Problem 2
        if(value == Data)
        {
            return true; //<-- base case 
        }
        else
        {
            if(value < Data)
            {    
                if(Left is not null)
                {
                     
                    return Left.Contains(value); //<---- recursive
                }   
            }

            if(value > Data)
            {
                if(Right is not null)
                {
                    return Right.Contains(value); // <--- recursive
                }
            }
        }

        return false;
    }

    public int GetHeight()
    {
        var heightInt = 0;

        // TODO Start Problem 4
        
        if(Left is not null && Right is not null)
        {
            heightInt = 1 + Math.Max(Left.GetHeight(), Right.GetHeight());
        }
        else if(Left is null && Right is null)
        {
          heightInt = 1;   
        } 
        else if (Left is null )
        {
            heightInt = 1 + Right?.GetHeight()?? 0;
        }
        else if( Right is null)
        {
            heightInt = 1 + Left?.GetHeight()??  0;
        }


        return heightInt; // Replace this line with the correct return statement(s)
    }
}