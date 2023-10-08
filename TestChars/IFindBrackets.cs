namespace TestChars;

public interface IFindBrackets
{
    bool AreMatchingBrackets(char openBracket, char closeBracket);
    bool IsClosingBracket(char bracket);
    bool IsOpeningBracket(char bracket);
    bool IsValidBrackets(char[] brackets);

}
