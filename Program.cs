namespace Han
{
    public class Program
    {
        public List<Function> Functions { get; set; } = new List<Function>();
        public List<IStatement> Blocks { get; set; } = new List<IStatement>();

        static void Main(string[] args)
        {
            Console.Write("Han 소스 파일 경로 : ");
            string path = Console.ReadLine();
            Console.WriteLine("\n==========출력 내용==========\n");

            var scanner = new Scanner();
            Parser parser;
            IngameManagerV2.Interpreter = new Interpreter();

            if (!File.Exists(path))
            {
                ExceptionManager.Throw($"Can't read the script because file doesn't exists.\n(File Path: '{path}')", "IngameManagerV2/Script");
                return;
            }

            string sourceCode = File.ReadAllText(path);
            List<Token> tokenList = scanner.Scan(sourceCode);
            parser = new Parser(ref tokenList);

            Program syntaxTree = parser.Parse();
            IngameManagerV2.Interpreter.Interpret(syntaxTree);

            Console.WriteLine("\n==========출력 끝==========\n");
            Console.WriteLine("아무 키나 눌러 종료...");
            Console.ReadLine();
        }
    }
}
