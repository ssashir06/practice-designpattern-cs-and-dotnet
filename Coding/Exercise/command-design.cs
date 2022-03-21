// using System;

// namespace Coding.Exercise
// {
//     public class Command
//     {
//         public enum Action
//         {
//             Deposit,
//             Withdraw
//         }

//         public Action TheAction;
//         public int Amount;
//         public bool Success;
//     }

//     public class Account
//     {
//         public int Balance { get; set; }

//         public void Process(Command c)
//         {
//             switch (c.TheAction)
//             {
//                 case Command.Action.Deposit:
//                     Balance += c.Amount;
//                     c.Success = true;
//                     Console.WriteLine($"Proceeded: Add {c.Amount}, Total {Balance}");
//                     break;
//                 case Command.Action.Withdraw:
//                     if (Balance >= c.Amount)
//                     {
//                         Balance -= c.Amount;
//                         c.Success = true;
//                         Console.WriteLine($"Proceeded: Minus {c.Amount}, Total {Balance}");
//                     }
//                     else
//                     {
//                         Console.WriteLine($"Cannot proceeded: Minus {c.Amount}, Total {Balance}");
//                     }
//                     break;
//                 default:
//                     throw new ArgumentException();
//             }
//         }
//     }
// }
