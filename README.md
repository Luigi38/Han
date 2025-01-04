# 한
 ![intro](https://github.com/Luigi38/Han/blob/main/test.png?raw=true)
 > [!NOTE]
 > 하나의, 프로그래밍 언어
> 
박세연 제작

## 기능
- 출력: `print`
- 함수: `label`
- 변수: `define`
- 주석: `#`

## 예제
```rpy
define value = 13 # 전역 변수

label start:
    print "Hello, world!"
    
    # 변수 할당
    define add = value + 4
    print "13 + 4 = "
    print add
```

출력 결과
```
Hello, world!
13 + 4 = 
17
```

## 인터프리터 사용법
```c#
string path = "filename.han";
var scanner = new Scanner();
Parser parser;
Interpreter interpreter = new Interpreter();

if (!File.Exists(path))
{
    Console.WriteLine("오류! 파일이 존재하지 않습니다.")
    return;
}

string sourceCode = File.ReadAllText(path);
List<Token> tokenList = scanner.Scan(sourceCode);
parser = new Parser(ref tokenList);

Program syntaxTree = parser.Parse();
interpreter.Interpret(syntaxTree);
```
