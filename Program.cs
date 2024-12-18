using System.ComponentModel;

namespace TreesLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            BinaryTree<string> tree = GetTree();
            BinaryTreeNode<string>? node = tree.Root;
            while (node != null)
            {
                if (node.Left != null && node.Right != null)
                {
                    Console.WriteLine(node.Data);
                    node = Console.ReadKey(true).Key switch
                    {
                        ConsoleKey.Y => node.Left,
                        ConsoleKey.N => node.Right,
                        _ => node
                    };
                }
                else
                {
                    Console.WriteLine(node.Data);
                    node = null;
                }
            }*/

            BinaryTree<string> GetTree()
            {
                BinaryTree<string> tree = new();

                tree.Root = new BinaryTreeNode<string>()
                {
                    Data = "Do you have an experience in app development ? ",

                    Children =
                    [
                    new BinaryTreeNode<string>()
                        {
                        Data = "Have you worked as a developer for 5 + years ? ",

                        Children =
                            [
                            new() { Data = "Apply as a senior developer" },

                            new() { Data = "Apply as a middle developer" }
                            ]
                        },
                    new BinaryTreeNode<string>()
                        {
                        Data = "Have you completed a university?",
                        Children =
                            [
                            new() { Data = "Apply as a junior developer" },

                            new BinaryTreeNode<string>()
                                {
                                Data = "Have you completed MSSA?",

                                Children =
                                    [
                                    new() { Data = "Apply for entry-level developer" },

                                    new BinaryTreeNode<string>()
                                        {
                                        Data = "Have you applied for MSSA?",

                                        Children =
                                        [
                                            new() {Data="Wait for acceptance"},

                                            new() {Data = "Apply for next MSSA cycle"}
                                        ]
                                    }
                                    ]
                                }
                            ]
                        }
                    ]
                };
                tree.Count = 9;

                return tree;
            }

        }


    }



}
