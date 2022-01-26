

class Solution
{
    //Write your code here
    Stack<char> stack = new Stack<char>();
    Queue<char> queue = new Queue<char>();

    public void pushCharacter(char _c)
    {
        stack.Push(_c);
    }
    public void enqueueCharacter(char _c)
    {
        queue.Enqueue(_c);
    }
    public char popCharacter()
    {
        return stack.Pop();
    }
    public char dequeueCharacter()
    {
        return queue.Dequeue();
    }


