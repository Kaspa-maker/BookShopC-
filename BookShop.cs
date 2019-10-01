using System;
using System.Collections;

namespace BookShop
{
	class Book
	{
		private int id;
		private string title;
		private double price;
		private string genre;
		private string author;

		public Book(int id, string title, double price, string genre, string author)
		{
			this.id = id;
			this.title = title;
			this.price = price;
			this.genre = genre;
			this.author = author;
		}

		public void print()
		{
			Console.WriteLine ("----------------------------");
			Console.WriteLine ("Id \t " + id);
			Console.WriteLine ("Title \t " + title);
			Console.WriteLine ("Author \t" + author);
			Console.WriteLine ("Genre \t" + genre);
			Console.WriteLine ("Price \t " + price);
			Console.WriteLine ("----------------------------");
		}

		public int getId()
		{
			return id;
		}
		public string getTitle()
		{
			return title;
		}
		public double getPrice()
		{
			return price;
		}
		public string getGenre()
		{
			return genre;
		}
		public string getAuthor()
		{
			return author;
		}
		public void setId(int id)
		{
			this.id = id;
		}
		public void setTitle(string title)
		{
			this.title = title;
		}
		public void setPrice(double price)
		{
			this.price = price;
		}
		public void setAuthor(string author)
		{
			this.author = author;
		}
		public void setGenre(string genre)
		{
			this.genre = genre;
		}


	}

// Start of Main Class
	class MainClass
	{
		private static int centralId = 101;
		private static ArrayList allBooks = new ArrayList();

		public static void Main (string[] args)
		{
			menu ();
		}
		private static void addBook()
		{
			Console.WriteLine ("Enter book name");
			string title = Console.ReadLine ();
			Console.WriteLine ("Enter book author");
			string author = Console.ReadLine ();
			Console.WriteLine ("Enter genre");
			string genre = Console.ReadLine ();
			Console.WriteLine ("Enter price");
			double price = Convert.ToDouble (Console.ReadLine ());
			Book b = new Book (centralId, title, price, genre, author);
			centralId++;
			allBooks.Add (b);
		}

		private static void printBooks()
		{
			foreach(Book i in allBooks)
			{
				i.print ();
			}

		}

		private static void deleteBook()
		{
			printBooks ();
			Console.WriteLine ("Enter the id of the book you wish to delete");
			int toDelete = Convert.ToInt16 (Console.ReadLine ());

			foreach (Book i in allBooks) 
			{
				if (toDelete == i.getId ()) 
				{
					allBooks.Remove (i);
					Console.WriteLine ("Item has been removed");
					break;
				}

			}

		}

		private static void editBook()
		{
			printBooks ();
			Console.WriteLine ("Please choose which book you wish to edit");
			int toEdit = Convert.ToInt16 (Console.ReadLine ());

			foreach (Book i in allBooks) 
			{
				if (toEdit == i.getId ()) 
				{
					Console.WriteLine ("Press 1 to Edit Title");
					Console.WriteLine ("Press 2 to Edit Author Name");
					Console.WriteLine ("Press 3 to Edit Genre");
					Console.WriteLine ("Press 4 to Edit Price");
					Console.WriteLine ("Press 5 to Return to Menu");

					string choice = Console.ReadLine ();

					switch (choice) 
					{
						case "1":
						{
							Console.WriteLine ("Please enter new Title to replace " + i.getTitle ());
							string newTitle = Console.ReadLine ();
							i.setTitle (newTitle);
							break;
						}
						case "2":
						{
							Console.WriteLine ("Please enter new Author to replace " + i.getAuthor ());
							string newAuthor = Console.ReadLine ();
							i.setAuthor (newAuthor);
							break;
						}
					case "3":
						{
							Console.WriteLine ("Please enter new Genre to replace " + i.getGenre ());
							string newGenre = Console.ReadLine ();
							i.setGenre(newGenre);
							break;
						}
					case "4":
						{
							Console.WriteLine ("Please enter new price to replace " + i.getPrice ());
							double newPrice = Convert.ToDouble(Console.ReadLine ());
							i.setPrice (newPrice);
							break;
						}
					case "5":
						{
							menu ();
							break;
						}

					}


				}

			}



		}

		private static void printByGenre()
		{
			Console.WriteLine ("Enter genre");
			string searchGenre = Console.ReadLine ();

			foreach (Book i in allBooks) 
			{
				if (i.getGenre ().Equals (searchGenre))
				{
					i.print ();
				}
			}
		}

		private static void menu()
		{
			Console.WriteLine ("Press 1 to Add New Book");
			Console.WriteLine ("Press 2 to Edit a Book");
			Console.WriteLine ("Press 3 to Delete a Book");
			Console.WriteLine ("Press 4 to Print All Books");
			Console.WriteLine ("Press 5 to Print Books by Genre");
			Console.WriteLine ("Press 6 to Exit");

			string choice = Console.ReadLine ();

			switch (choice) 
			{
				case "1":
				{
					addBook ();
					break;
				}
				case "2":
				{
					editBook ();
					break;
				}
				case "3":
				{
					deleteBook ();
					break;
				}
				case "4":
				{
					printBooks ();
					break;
				}
				case  "5":
				{
					printByGenre ();
					break;
				}
				case  "6":
				{
					Environment.Exit (0);
					break;
				}

			}
			menu ();
		}

	}
}
