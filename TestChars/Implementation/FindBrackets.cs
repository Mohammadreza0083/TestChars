namespace TestChars;

public class FindBrackets : IFindBrackets
{
    #region FindTypeOfBrackets
    public bool IsClosingBracket(char bracket)
    {
        if (bracket == ')' || bracket == ']' || bracket == '}')
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool IsOpeningBracket(char bracket)
    {
        if (bracket == '(' || bracket == '[' || bracket == '{')
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    #endregion

    #region MatchingBrackets
    public bool AreMatchingBrackets(char openBracket, char closeBracket)
    {
        if (openBracket == '(' && closeBracket == ')')
        {
            return true;
        }
        else if (openBracket == '[' && closeBracket == ']')
        {
            return true;
        }
        else if (openBracket == '{' && closeBracket == '}')
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    #endregion

    public bool IsValidBrackets(char[] brackets)
    {
        Stack<char> collection = new Stack<char>();
        foreach (char bracket in collection)
        {
            if (IsOpeningBracket(bracket))
            {
                collection.Push(bracket);
            }
            else if (IsClosingBracket(bracket))
            {
                if (collection.Count == 0 || !AreMatchingBrackets(collection.Peek(), bracket))
                {
                    return false;
                }
                else
                {
                    collection.Pop();

                }
            }
            else
            {
                return false;
            }
        }
        if (collection.Count == 0)
        {
            return true;
        }
        else
        {
            return false;
        }

    }



}
