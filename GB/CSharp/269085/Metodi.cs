// очень плохой код. пример
bool Metodi(int chislo)
{
      bool resultati = false;
      if ( chislo % 2 ==0 )
{
    resultati = true;
          }
       else {resultati = false; }
         if  (resultati == false)
{   return false;
        }       else {
            return true;
}
}

// отфомрматированный вариант кода
bool Metodi(int chislo)
{
    bool resultati = false;
    if(chislo % 2 == 0)
        resultati = true;
    else
        resultati = false;
    
    if(resultati == false)
        return false;
    else
        return true;
}

// понятный вариант
bool Metodi(int chislo)
{
    bool resultati = false;
    return chislo % 2 == 0 ? true : false;
}

// самый короткий вариант
bool Metodi(int chislo)
{
    return chislo % 2 == 0;
}

// Корректное название метода и аргумента
bool IsEven(int value)
{
    return value % 2 == 0;
}