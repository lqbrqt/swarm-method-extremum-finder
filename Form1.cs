using System;
using System.Drawing;
using System.Windows.Forms;

using ZedGraph; //Подключаем библиотеку вывода графиков

namespace ReviewedJuliaPractice
{
	public partial class Form1 : Form //Класс формы, обробатывает события
    {
        public Form1() //Инициализатор, выполняется при запуске программы
        {
            InitializeComponent();
			DrawGraph(-50, 50); //Рисуем заданную функцию на заданном диапазоне

        }

		Func func = new Func(-50, 50); // Создаем объект класса Func с стандартными значениями диапазона - класса заданой функции. Объявляется на 276 строке
		Swarm _swarm = null; //Создаем пустой объект роя. Объявляется на 297 строке

		private void DrawGraph(double xmin, double xmax) //Метод, рисующий данную функцию на заданном диапазоне
		{
			// Получим панель для рисования
			GraphPane pane = _swarmGraph.GraphPane;			

			// Создадим список точек
			PointPairList list = new PointPairList();

			double maxYgraf = func.FinalFunction(xmin);
			double minYgraf = func.FinalFunction(xmin);

			// Заполняем список точек
			for (double x = xmin; x <= xmax; x += 0.01)
			{
				double y = func.FinalFunction(x); // Метод FinalFunction возвращает значение y данной функции, принимая параметр x
				list.Add(x, y);
			}

			// Создадим кривую с названием "Исследуемая функция",
			// которая будет рисоваться голубым цветом (Color.Blue),
			// Опорные точки выделяться не будут (SymbolType.None)
			LineItem myCurve = pane.AddCurve("Исследуемая функция", list, Color.Blue, SymbolType.None);

			// Вызываем метод AxisChange (), чтобы обновить данные об осях.
			// В противном случае на рисунке будет показана только часть графика,
			// которая умещается в интервалы по осям, установленные по умолчанию
			pane.XAxis.Scale.Min = func.MinValue;
			pane.XAxis.Scale.Max = func.MaxValue;

			pane.YAxis.Scale.Min = func.MinValue;
			pane.YAxis.Scale.Max = func.MaxValue;

			_swarmGraph.AxisChange();

			// Обновляем график
			_swarmGraph.Invalidate();
		}

		private void initParticlesButton_Click(object sender, EventArgs e) // Обработчик нажатия на кнопку "Инициализировать систему"
        {
			_errorProvider.Clear();

			double currentVelocityRatio; //Обработчик ошибок и ввод коэффициентов
			try
			{
				currentVelocityRatio = Convert.ToDouble(currentVelocityRatioBox.Text);
			}
			catch (FormatException)
			{
				_errorProvider.SetError(currentVelocityRatioBox, "Неправильный формат числа");
				return;
			}


			double localBestRatio;
			try
			{
				localBestRatio = Convert.ToDouble(localBestAnsRatioBox.Text);
			}
			catch (FormatException)
			{
				_errorProvider.SetError(localBestAnsRatioBox, "Неправильный формат числа");
				return;
			}


			double globalBestRatio;
			try
			{
				globalBestRatio = Convert.ToDouble(globalBestAnsRatioBox.Text);
			}
			catch (FormatException)
			{
				
				_errorProvider.SetError(globalBestAnsRatioBox, "Неправильный формат числа");
				return;
			}

			if ((localBestRatio + globalBestRatio) <= 4)
			{
				_errorProvider.SetError(globalBestAnsRatioBox, "Сумма значений коэффициентов собственного и глобального лучших значений должна быть больше 4");
				return;
			}

			double minValue;
			try
			{
				minValue = Convert.ToDouble(minValueBox.Text);
			}
			catch (FormatException)
			{

				_errorProvider.SetError(minValueBox, "Неправильный формат числа");
				return;
			}

			double maxValue;
			try
			{
				maxValue = Convert.ToDouble(maxValueBox.Text);
			}
			catch (FormatException)
			{

				_errorProvider.SetError(maxValueBox, "Неправильный формат числа");
				return;
			}

			
			if(minValue >= maxValue)
			{
				_errorProvider.SetError(maxValueBox, "Максимальное значение не может быть меньше или равно минимального");
				return;
			}

			int swarmSize = (int)particleCountNumeric.Value; //Задаем колество частиц роя

			func = new Func(minValue, maxValue); //Присваеваем func объект класса Func с заданным диапазоном


			InitSwarm( 
				func,
				swarmSize,
				currentVelocityRatio,
				localBestRatio,
				globalBestRatio); // Инициализируем рой заданными в настройках параметрами
		}

		void InitSwarm( // Реализация метода реализации роя по заданным параметрам
			Func func,
			int swarmSize,
			double currentVelocityRatio,
			double localBestRatio,
			double globalBestRatio)
		{
			_swarm = new Swarm(func,
				swarmSize,
				currentVelocityRatio,
				localBestRatio,
				globalBestRatio
				); //Присвоение переменной _swarm объекта Swarm (реализован на 318 строке)

			UpdateResults(); //Вызываем метод обновления результатов работы алгоритма (лучшее решение)
		}

		void UpdateResults() //Реализация метода обновления результатов работы алгоритма
		{
			
			
			yAnsBox.Text = _swarm.BestFinalFunc.ToString(); // Выводим в текстовые боксы справа снизу лучший результат работы алгоритма
			xAnsBox.Text = _swarm.BestPosition.ToString();
			UpdateSwarmGraph(); //Обновляем график
		}

		public string ResultToString(Swarm swarm) //Метод преобразования лушего результата в строку 
		{
			return swarm.BestPosition.ToString();
		}

		void UpdateSwarmGraph() // Реализация метода обновления графика
		{

			

			PointPairList particlesList = new PointPairList(); // Создаем список точек
			foreach (Particle particle in _swarm.Particles)
			{
				particlesList.Add(particle.Position, func.FinalFunction(particle.Position)); //Заполняем координаты точек координатами чатиц
			}

			GraphPane pane = _swarmGraph.GraphPane; //Получаем доступ к полотну
			pane.CurveList.Clear(); //Очищаем полотно от предыдущих записей

			DrawGraph(func.MinValue, func.MaxValue); //Вызываем метод отрисовки заданной функции

			if (_swarm.Iteration == 0) //Если мы еще ни разу не итерировались (то есть при первой итерации) установим границы отображения графика
			{
				pane.XAxis.Scale.Min = func.MinValue;
				pane.XAxis.Scale.Max = func.MaxValue;

				pane.YAxis.Scale.Min = func.MinValue;
				pane.YAxis.Scale.Max = func.MaxValue;
			}

			LineItem particlesCurve = pane.AddCurve("Все решения", particlesList,
				Color.Black, SymbolType.Default); //Рисуем кривую решений

			particlesCurve.Line.IsVisible = false; //Выключаем отображение линии между точками
 			particlesCurve.Symbol.Fill.Color = Color.Black; //Устанавиваем черный цвет
			particlesCurve.Symbol.Fill.Type = FillType.Solid; //Закрашиваем точечки
			particlesCurve.Symbol.Size = 4; //Устанавливаем размер точки (можем менять)

			_swarmGraph.AxisChange(); // Выравниваем отображение графика
			_swarmGraph.Invalidate();
		}

		private void oneIterationButton_Click(object sender, EventArgs e) //Обрабатываем нажатие кнопки "Сделать одну итерацию"
		{
			MakeIteration(1);
		}

		void MakeIteration(int iterationCount) //Реализация метода итерации 
		{
			if (_swarm == null)
			{
				return;
			}

			for (int i = 0; i < iterationCount; i++)
			{
				_swarm.NextIteration();
			}

			UpdateResults();
		}

		private void tenIterationButton_Click(object sender, EventArgs e) //Обрабатываем нажатие кнопки "Сделать 10 итераций"
		{
			MakeIteration(10);
		}

		private void hundredIterationButton_Click(object sender, EventArgs e) //Обрабатываем нажатие кнопки "Сделать сто итерацию"
		{
			MakeIteration(100);
		}

		private void nIterationButton_Click(object sender, EventArgs e) //Обрабатываем нажатие кнопки "Сделать N итераций"
		{
			int n;
			try
			{
				n = Convert.ToInt32(iterationCountRatio.Text.ToString());
			}
			catch
			{
				_errorProvider.SetError(iterationCountRatio, "Количество итераций должно быть натуральным числом"); //Обработчик ошибок и присвоение переменной n
				return;
			}

			if(n <= 0)
			{
				_errorProvider.SetError(iterationCountRatio, "Количество итераций не может быть меньше либо равно нуля");
				return;
			}

			MakeIteration(n); 

		}
	}



	public class Func //Реализация класса функции
	{
		public Func(double minvalue, double maxvalue) // Релизация конструктора класса по диапазону значений 
		{
			this.MinValue = minvalue;
			this.MaxValue = maxvalue;
		}


		public double FinalFunction(double x)  //Кодим саму функцию 
		{
			double result = 0.0;

			result = 0.5 * x * x - 4.8 * x + 3.5; //Вот она родимая красивая

			return result;
		}

        public double MinValue { get; set; }

        public double MaxValue { get; set; }

	}

	public class Swarm //Реализация класса роя
	{
		public Swarm(
			Func func,
			int swarmsize,
			double currentVelocityRatio,
			double localVelocityRatio,
			double globalVelocityRatio) //Реализация конструктора роя по заданным параметрам
		{
			_func = func;
			_currentVelocityRatio = currentVelocityRatio;
			_localVelocityRatio = localVelocityRatio;
			_globalVelocityRatio = globalVelocityRatio;
			_iteration = 0;

			_particles = CreateParticles(swarmsize);
		}

		public void NextIteration() //Реализация перехода на сделающий шаг итерации
		{
			foreach (Particle particle in _particles)
			{
				particle.NextIteration(); // Вызов в цикле перехода на сделающий шаг итерации каждой частицы (Класс Particle описан на 420 строке)
			}

			_iteration++;
		}

		public int Size
		{
			get { return _particles.Length; }
		}


		public double MinValues
		{
			get { return _func.MinValue; }
		}


		public double MaxValues
		{
			get { return _func.MaxValue; }
		}


		Particle[] CreateParticles(int swarmSize) //Метод создания массива частиц (читай Роя)
		{
			Particle[] swarm = new Particle[swarmSize];
			for (int i = 0; i < swarmSize; i++)
			{
				swarm[i] = new Particle(this);
			}

			return swarm;
		}

		Func _func;

		Particle[] _particles;

		public Particle[] Particles
		{
			get { return _particles; }
		}

		private double _bestFinalFunc = double.MaxValue;

		public double BestFinalFunc
		{
			get { return _bestFinalFunc; }
		}

		double _bestPosition;

		public double BestPosition
		{
			get { return _bestPosition; }
		}

		double _currentVelocityRatio;

		public double CurrentVelocityRatio
		{
			get { return _currentVelocityRatio; }
		}

		double _localVelocityRatio;

		public double LocalVelocityRatio
		{
			get { return _localVelocityRatio; }
		}

		double _globalVelocityRatio;

		public double GlobalVelocityRatio
		{
			get { return _globalVelocityRatio; }
		}


		int _iteration;

		public int Iteration
		{
			get { return _iteration; }
		}

		internal double FinalFunction(double position)
		{
			double finalfunc = _func.FinalFunction(position);

			if (finalfunc < _bestFinalFunc)
			{
				_bestFinalFunc = finalfunc;
				_bestPosition = position;
			}

			return finalfunc;
		}
	}

	public class Particle //Реализация класса частицы
	{
		public Particle(Swarm swarm) //Конструктор частицы
		{
			_swarm = swarm;

			_currentPosition = GetInitPosition(swarm);
			_localBestPosition = _currentPosition;
			_localBestFinalFunc = swarm.FinalFunction(_currentPosition);

			_velocity = GetInitVelocity(swarm);
		}


		double GetInitPosition(Swarm swarm) // Присваивание ей случайных координат в пределах заданного диапазона
		{
			double position;

			
			position = _random.NextDouble() * (swarm.MaxValues - swarm.MinValues) + swarm.MinValues;
			


			return position;
		}

		double GetInitVelocity(Swarm swarm) //Метод возвращающий внутреннюю скорость
		{
			double velocity = 0;

			
			double minval = -(swarm.MaxValues - swarm.MinValues);
			double maxval = (swarm.MaxValues - swarm.MinValues);

			velocity = _random.NextDouble() * (maxval - minval) + minval;
			

			return velocity;
		}

		static Random _random = new Random();
		Swarm _swarm;

		double _currentPosition;

		public double Position //Возвращает текущую позицию
		{
			get { return _currentPosition; }
		}

		double _localBestPosition;
		double _localBestFinalFunc;

		private double _velocity;

		public double Velocity
		{
			get { return _velocity; }
		}

		internal void NextIteration() //Переход к следующему шагу итерации
		{
			CorrectVelocity();
			MoveSelf();
			CheckFinalFunc();
		}


		private void CheckFinalFunc() 
		{
			double finalfunc = _swarm.FinalFunction(_currentPosition);
			if (finalfunc < _localBestFinalFunc)
			{
				_localBestFinalFunc = finalfunc;
				_localBestPosition = _currentPosition;
			}
		}

		private void MoveSelf() //Передвижение частицы на основе работы алгоритма
		{
				_currentPosition += _velocity;
		}


		private void CorrectVelocity() 
		{
			double veloRatio = _swarm.LocalVelocityRatio + _swarm.GlobalVelocityRatio;

			double commonRatio = (2.0 * _swarm.CurrentVelocityRatio /
				(Math.Abs(2.0 - veloRatio -
					Math.Sqrt(veloRatio * veloRatio - 4.0 * veloRatio))));

			
				double newVelocity_part1 = commonRatio * _velocity;

				double newVelocity_part2 = commonRatio *
					_swarm.LocalVelocityRatio *
					_random.NextDouble() *
					(_localBestPosition - _currentPosition);

				double newVelocity_part3 = commonRatio *
					_swarm.GlobalVelocityRatio *
					_random.NextDouble() *
					(_swarm.BestPosition - _currentPosition);

				_velocity = newVelocity_part1 + newVelocity_part2 + newVelocity_part3;
		} 
	}
}
