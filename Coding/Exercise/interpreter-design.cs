// using System;
// using System.Collections.Generic;
// using System.Text;

// namespace Coding.Exercise
// {
//     public interface IElement
//     {
//         int Value { get; }
//     }

//     public class Integer : IElement
//     {
//         public Integer(int value)
//         {
//             Value = value;
//         }

//         public int Value { get; }
//     }

//     public class BinaryOperation : IElement
//     {
//         public enum Type
//         {
//             Addition,
//             Subtraction
//         }

//         public Type MyType;
//         public IElement Left, Right;

//         public BinaryOperation()
//         {
//             Left = new Integer(0);
//             Right = new Integer(0);
//         }

//         public int Value
//         {
//             get
//             {
//                 switch (MyType)
//                 {
//                     case Type.Addition:
//                         return Left.Value + Right.Value;
//                     case Type.Subtraction:
//                         return Left.Value - Right.Value;
//                     default:
//                         throw new ArgumentOutOfRangeException();
//                 }
//             }
//         }
//     }

//     public class Token
//     {
//         public enum Type
//         {
//             Integer, Plus, Minus, Variable
//         }

//         public Type MyType;
//         public string Text;

//         public Token(Type type, string text)
//         {
//             if (text == null)
//             {
//                 throw new ArgumentNullException(paramName: nameof(text));
//             }
//             MyType = type;
//             Text = text;
//         }

//         public override string ToString()
//         {
//             return $"`{Text}`";
//         }
//     }
//     public class ExpressionProcessor
//     {
//         public Dictionary<char, int> Variables = new Dictionary<char, int>();
//         List<Token> Lex(string input)
//         {
//             var result = new List<Token>();

//             for (int i = 0; i < input.Length; i++)
//             {
//                 var ch = input[i];
//                 if (ch == '+')
//                 {
//                     result.Add(new Token(Token.Type.Plus, "+"));
//                 }
//                 else if (ch == '-')
//                 {
//                     result.Add(new Token(Token.Type.Minus, "-"));
//                 }
//                 else if (ch >= 'a' && ch <= 'z' || ch >= 'A' && ch <= 'Z')
//                 {
//                     result.Add(new Token(Token.Type.Variable, ch.ToString()));
//                 }
//                 else if (char.IsNumber(ch))
//                 {
//                     var sb = new StringBuilder(input[i].ToString());
//                     for (int j = i + 1; j <= input.Length; ++j)
//                     {
//                         if (j < input.Length && char.IsDigit(input[j]))
//                         {
//                             sb.Append(input[j]);
//                             ++i;
//                         }
//                         else
//                         {
//                             result.Add(new Token(Token.Type.Integer, sb.ToString()));
//                             break;
//                         }
//                     }
//                 }
//                 else
//                 {
//                     throw new CalculateErrorException();
//                 }
//             }

//             return result;
//         }

//         IElement Parse(IReadOnlyList<Token> tokens)
//         {
//             var result = new BinaryOperation();
//             bool haveLHS = false;
//             for (int i = 0; i < tokens.Count; i++)
//             {
//                 var token = tokens[i];

//                 // look at the type of token
//                 switch (token.MyType)
//                 {
//                     case Token.Type.Plus:
//                         result.MyType = BinaryOperation.Type.Addition;
//                         break;
//                     case Token.Type.Minus:
//                         result.MyType = BinaryOperation.Type.Subtraction;
//                         break;
//                     case Token.Type.Integer:
//                         {
//                             var integer = new Integer(int.Parse(token.Text));
//                             if (!haveLHS)
//                             {
//                                 result.Left = integer;
//                                 haveLHS = true;
//                             }
//                             else
//                             {
//                                 result.Right = integer;
//                                 var boNew = new BinaryOperation()
//                                 {
//                                     Left = result,
//                                 };
//                                 result = boNew;
//                             }
//                         }
//                         break;
//                     case Token.Type.Variable:
//                         {
//                             if (token.Text.Length > 1)
//                             {
//                                 throw new CalculateErrorException();
//                             }
//                             var ch = token.Text[0];
//                             if (!Variables.ContainsKey(ch))
//                             {
//                                 throw new CalculateErrorException();
//                             }
//                             var integer = new Integer(Variables[ch]);
//                             if (!haveLHS)
//                             {
//                                 result.Left = integer;
//                                 haveLHS = true;
//                             }
//                             else
//                             {
//                                 result.Right = integer;
//                                 var boNew = new BinaryOperation()
//                                 {
//                                     Left = result,
//                                 };
//                                 result = boNew;
//                             }
//                         }
//                         break;
//                     default:
//                         throw new CalculateErrorException();
//                 }
//             }
//             return result;
//         }

//         class CalculateErrorException : Exception { }

//         public int Calculate(string expression)
//         {
//             try
//             {
//                 var tokens = Lex(expression);
//                 var result = Parse(tokens);
//                 return result.Value;
//             }
//             catch (CalculateErrorException)
//             {
//                 Console.Error.WriteLine("Failed to calculate!");
//                 return 0;
//             }
//         }
//     }
// }
