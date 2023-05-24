using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
/// <summary>
/// Класс ювелирное изделие
/// </summary>

{
	class ювелирное_изделие
	{
		/// <summary>
		/// Переменная - вес
		/// </summary>
		private int вес;
		/// <summary>
		/// Переменная - цена
		/// </summary>
		private int цена_за_грам;
		/// <summary>
		/// Инициализация класса ювелирное изделие
		/// </summary>
		/// <param name="вес1">вес</param>
		/// <param name="цена1">цена</param>
		public void Init(int вес1, int цена1)
		{
			вес = вес1;
			цена_за_грам = цена1;
		}
		void Read()
		{
			/// <summary>
			/// Метод, вводящий данные о ювелирной изделии
			/// </summary>
			Console.Write("введите вес изделия:");
			вес = Convert.ToInt32(Console.ReadLine());
			Console.Write("введите цену изделия:");
			цена_за_грам = Convert.ToInt32(Console.ReadLine());
		}
		/// <summary>
		/// Метод, демонстрирующий вес изделия, цену за грамм
		/// </summary>
		public void Display()
		{
			Console.Write("вес изделия= {0} ,цена изделия за грамм= {1} \n", вес, цена_за_грам);
		}
		/// <summary>
		/// Метод, возвращающий цену ювелирного изделия
		/// </summary>
		/// \f$price = weight * price per gram\f$
		/// <returns>Возвращает цену ювелирного изделия</returns>
		public int цена_изделия()
		{
			int цена = вес * цена_за_грам;
			return цена;
		}
		/// <summary>
		/// Метод, возвращающий общую стоимость ювелирного изделия
		/// </summary>
		public int общая_стоимость()
		{
			return цена_за_грам = цена_за_грам * вес;
		}

	}
	/// <summary>
	/// Класс ювелирный_магазин (имеющий ювелирные изделия)
	/// </summary>
	class ювелирный_магазин
	{
		/// <summary>
		/// Первое ювелирное изделие
		/// </summary>
		private ювелирное_изделие a = new ювелирное_изделие();
		/// <summary>
		/// Второе ювелирное изделие
		/// </summary>
		private ювелирное_изделие b = new ювелирное_изделие();
		/// <summary>
		/// Количество первого ювелирного изделия
		/// </summary>
		private int x;
		/// <summary>
		///  Количество второго ювелирного изделия
		/// </summary>
		private int y;
		/// <summary>
		/// Инициализация класса ювелирный магазин
		/// </summary>
		/// <param name="v1">Вес1</param>
		/// <param name="c1">Цена1</param>
		/// ![Image](../images/izdelie.jpg)
		/// <param name="v2">Вес2</param>
		/// <param name="c2">Цена2</param>
		/// <param name="x1">Кол-во первого изделия</param>
		/// <param name="y1">Кол-во второго изделия</param>
		public void Init(int v1, int c1, int v2, int c2, int x1, int y1)
		{

			a.Init(v1, c1);
			b.Init(v2, c2);
			x = x1;
			y = y1;
		}
		/// <summary>
		/// Метод, вводящий данные о ювелирной изделии
		/// </summary>
		void Read()
		{
			Console.Write("введите количество 1 изделия:");
			x = Convert.ToInt32(Console.ReadLine());
			Console.Write("введите количество 2 изделия:");
			y = Convert.ToInt32(Console.ReadLine());
		}
		/// <summary>
		/// Метод, демонстрирующий информацию об изделиях
		/// </summary>
		public void Display()
		{
			Console.WriteLine("информация о 1 изделии: количество= {0} ", x);
			a.Display();
			Console.WriteLine("информация о 2 изделии: количество= {0} ", y);
			b.Display();
		}
		/// <summary>
		/// Метод, расчитывающий общую стоимость
		/// </summary>
		public int общая_стоимость()
		{
			return a.цена_изделия() * x + b.цена_изделия() * y;
		}
		/// <summary>
		/// Метод, расчитывающий наибольшую стоимость
		/// </summary>
		public ювелирное_изделие наибольшая_стоимость()
		{
			if (a.цена_изделия() > b.цена_изделия())
			{
				return a;
			}
			else
			{
				return b;
			}
		}
	}
	/// <summary>
	/// Класс абстрактный
	/// </summary>
	public abstract class абстрактный_класс
	{
		/// <summary>
		/// Фамилия
		/// </summary>
		protected String Fam;
		/// <summary>
		/// Год
		/// </summary>
		protected int Year;
		/// <summary>
		/// Инициализация абстрактного класса
		/// </summary>
		/// <param name="f">Фамилия</param>
		/// <param name="y">Год</param>
		public абстрактный_класс(String f, int y)
		{
			Fam = f;
			Year = y;
		}
		/// <summary>
		/// Метод, расчитывающий общую стоимость
		/// </summary>
		public abstract int Totalобщ();
	}
	/// <summary>
	/// Производный абстрактный класс 1. Класс наследуется от абстрактный_класс
	/// inherit абстрактный_класс
	/// </summary>
	class производный_абстрактный_класс_one : абстрактный_класс
	{
		/// <summary>
		/// Первое ювелирное изделие
		/// </summary>
		protected ювелирный_магазин R1 = new ювелирный_магазин();
		/// <summary>
		/// Второе ювелирное изделие
		/// </summary>
		protected ювелирный_магазин R2 = new ювелирный_магазин();
		/// <summary>
		/// Инициализация производного абстрактного класса
		/// </summary>
		/// <param name="f">Фамилия</param>
		/// <param name="y">Год</param>
		/// <param name="v1">Вес1</param>
		/// <param name="c1">Цена1</param>
		/// <param name="v2">Вес2</param>
		/// <param name="c2">Цена2</param>
		/// <param name="x1">Кол-во первого изделия</param>
		/// <param name="y1">Кол-во второго изделия</param>
		/// <param name="v12">Вес1</param>
		/// <param name="c12">Цена1</param>
		/// <param name="v22">Вес2</param>
		/// <param name="c22">Цена2</param>
		/// <param name="x12">Кол-во первого изделия</param>
		/// <param name="y12">Кол-во второго изделия</param>
		public производный_абстрактный_класс_one(String f, int y, int v1, int c1, int v2, int c2, int x1, int y1, int v12, int c12, int v22, int c22, int x12, int y12) : base(f, y)
		{
			R1.Init(v1, c1, v2, c2, x1, y1);
			R2.Init(v12, c12, v22, c22, x12, y12);
		}
		/// <summary>
		/// Метод перегрузки абстрактной функции
		/// </summary>
		public override int Totalобщ()  
		{
			return R1.общая_стоимость() + R2.общая_стоимость();
		}
	}
	/// <summary>
	/// Производный абстрактный класс 2. Класс наследуется от абстрактный_класс
	/// inherit абстрактный_класс
	/// </summary>
	class производный_абстрактный_класс_two : абстрактный_класс
	{
		/// <summary>
		/// Первое ювелирное изделие
		/// </summary>
		protected ювелирное_изделие R1 = new ювелирное_изделие();
		/// <summary>
		/// Второе ювелирное изделие
		/// </summary>
		protected ювелирное_изделие R2 = new ювелирное_изделие();
		/// <summary>
		/// Инициализация производного абстрактного класса
		/// </summary>
		/// <param name="f">Фамилия</param>
		/// <param name="y">Год</param>
		/// <param name="вес1">Вес1</param>
		/// <param name="цена1">Цена1</param>
		/// <param name="вес2">Вес2</param>
		/// <param name="цена2">Цена2</param>
		public производный_абстрактный_класс_two(String f, int y, int вес1, int цена1, int вес2, int цена2) : base(f, y)
		{
			R1.Init(вес1, цена1);
			R2.Init(вес2, цена2);
		}
		/// <summary>
		/// Метод перегрузки абстрактной функции
		/// </summary>
		public override int Totalобщ() 
		{
			return R1.общая_стоимость() + R2.общая_стоимость();
		}
	}
	/// <summary>
	/// Производный абстрактный класс 3. Класс наследуется от абстрактный_класс
	/// inherit абстрактный_класс
	/// </summary>
	class производный_абстрактный_класс_three : абстрактный_класс
	{
		/// <summary>
		/// Первое ювелирное изделие
		/// </summary>
		protected ювелирный_магазин R1 = new ювелирный_магазин();
		/// <summary>
		/// Второе ювелирное изделие
		/// </summary>
		protected ювелирное_изделие R2 = new ювелирное_изделие();
		/// <summary>
		/// Инициализация производного абстрактного класса
		/// </summary>
		/// <param name="f">Фамилия</param>
		/// <param name="y">Год</param>
		/// <param name="v1">Вес1</param>
		/// <param name="c1">Цена1</param>
		/// <param name="v2">Вес2</param>
		/// <param name="c2">Цена2</param>
		///<param name="x1">Кол-во первого изделия</param>
		/// <param name="y1">Кол-во второго изделия</param>
		/// <param name="вес1">Вес1</param>
		/// <param name="цена1">Цена1</param>
		public производный_абстрактный_класс_three(String f, int y, int v1, int c1, int v2, int c2, int x1, int y1, int вес1, int цена1) : base(f, y)
		{
			R1.Init(v1, c1, v2, c2, x1, y1);
			R2.Init(вес1, цена1);
		}
		/// <summary>
		/// Метод перегрузки абстрактной функции
		/// </summary>
		public override int Totalобщ()  
		{
			return R1.общая_стоимость() + R2.общая_стоимость();
		}
	}
	/// <summary>
	/// Производный абстрактный классFactory
	/// </summary>
	public abstract class абстрактный_классFactory
	{
		/// <summary>
		/// Создание абстрактного класса
		/// </summary>
		/// <param name="f">Фамилия</param>
		/// <param name="y">Год</param>
		public abstract абстрактный_класс Create(String f, int y);
	}
	/// <summary>
	/// Производный абстрактный классFactory 1. Класс наследуется от абстрактный_классFactory
	/// inherit абстрактный_классFactory
	/// </summary>
	public class производный_абстрактный_класс_oneFactory : абстрактный_классFactory
	{
		/// <summary>
		/// Перегрузка созданного абстрактного класса
		/// </summary>
		/// <param name="f">Фамилия</param>
		/// <param name="y">Год</param>
		public override абстрактный_класс Create(String f, int y)
		{
			return new производный_абстрактный_класс_one(f, y, 123, 764, 1265, 1, 634, 12, 123, 764, 1265, 1, 634, 12); // теперь объекты через new создаются здесь, а не в main
		}
	}
	/// <summary>
	/// Производный абстрактный классFactory 2. Класс наследуется от абстрактный_классFactory
	/// inherit абстрактный_классFactory
	/// </summary>
	public class производный_абстрактный_класс_twoFactory : абстрактный_классFactory
	{
		/// <summary>
		/// Перегрузка созданного абстрактного класса
		/// </summary>
		/// <param name="f">Фамилия</param>
		/// <param name="y">Год</param>
		public override абстрактный_класс Create(String f, int y)
		{
			return new производный_абстрактный_класс_two(f, y, 634, 12, 5, 12);
		}
	}
	/// <summary>
	/// Производный абстрактный классFactory 2. Класс наследуется от абстрактный_классFactory
	/// inherit абстрактный_классFactory
	/// </summary>
	public class производный_абстрактный_класс_threeFactory : абстрактный_классFactory
	{
		/// <summary>
		/// Перегрузка созданного абстрактного класса
		/// </summary>
		/// <param name="f">Фамилия</param>
		/// <param name="y">Год</param>
		public override абстрактный_класс Create(String f, int y)
		{
			return new производный_абстрактный_класс_three(f, y, 123, 764, 1265, 1, 634, 12, 2, 56);
		}
	}

	/// <summary>
	/// класс Mavenproject1. Иницилизация проекта
	/// </summary>
	public class Mavenproject1
	{
		/// <summary>
		/// Публичный метод Main, иницилизирующий программу
		/// </summary>
		static void Main(string[] args)
		{
			int k, m, n;

			абстрактный_классFactory squareFactory = new производный_абстрактный_класс_oneFactory(); // объект фабричного метода
			абстрактный_класс a = squareFactory.Create("Иванов", 2000); // задание объекта класса Square 

			squareFactory = new производный_абстрактный_класс_twoFactory(); // объект фабричного метода
			абстрактный_класс b = squareFactory.Create("Иванов", 2000); // задание объекта класса Square 

			squareFactory = new производный_абстрактный_класс_threeFactory(); // объект фабричного метода
			абстрактный_класс c = squareFactory.Create("Иванов", 2000); // задание объекта класса Square 
			k = a.Totalобщ(); // k=119186856

			m = b.Totalобщ(); // m=7668

			n = c.Totalобщ(); // n=59593540
			Console.Write("Общая стоимость производных абстрактных классов\n" + k + "\n" + m + "\n" + n + "\n");
		}
	}
}
