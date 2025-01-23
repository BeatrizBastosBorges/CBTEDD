#include <iostream>
#include <locale.h>

using namespace std;

class Data
{
    private:
        int 
            dia, 
            mes, 
            ano;

    public: 
        //constructors
            //com parâmetro
        Data(int dia, int mes, int ano)
        {
            this->dia = dia;
            this->mes = mes;
            this->ano = ano;
        }
            //sem parâmetro
        Data()
        {
            this->dia = 0;
            this->mes = 0;
            this->ano = 0;
        }

        //setters

        void setDia(int dia)
        {
            this->dia = dia;
        }

        void setMes(int mes)
        {
            this->mes = mes;
        }

        void setAno(int ano)
        {
            this->ano = ano;
        }

        //getters

        int getDia()
        {
            return this->dia;
        }

        int getMes()
        {
            return this->mes;
        }

        int getAno()
        {
            return this->ano;
        }
};

class Contato
{
    private: 
        string email,
               nome,
               telefone;
        Data dtnasc;
    public:
        //construtores
            //com parâmetros
        Contato(string email, string nome, string telefone, Data dtnasc)
        {
            this->email = email;
            this->nome = nome;
            this->telefone = telefone;
            this->dtnasc = dtnasc;
        }
            //sem parâmetros
        Contato()
        {
            this->email = "";
            this->nome = "";
            this->telefone = "";
            this->dtnasc = Data();
        }
            //setters
        void setEmail(string email)
        {
            this->email = email;
        }

        void setNome(string nome)
        {
            this->nome = nome;
        }

        void setTelefone(string telefone)
        {
            this->telefone = telefone;
        }

        void setDtnasc(Data dtnasc)
        {
            this->dtnasc = dtnasc;
        }
            //getters
        string getEmail()
        {
            return this->email;
        }

        string getNome()
        {
            return this->nome;
        }

        string getTelefone()
        {
            return this->telefone;
        }

        Data getDtnasc()
        {
            return this->dtnasc;
        }

        //métodos
        int Idade()
        {
            return 2024 - this->dtnasc.getAno();
        }
};

int main(int argc, char** argv)
{
    setlocale(LC_ALL, "");

    Contato contato[5];

    //criar contato
    for (int i = 0; i < 5; i++)
    {
        string email, nome, telefone;
        int dia, mes, ano;

        cout << "Digite o email do contato " << i + 1 << "\n" << endl;
        cin >> email;

        cout << "Digite o nome do contato " << i + 1 << "\n" << endl;
        cin >> nome;

        cout << "Digite o telefone do contato " << i + 1 << "\n" << endl;
        cin >> telefone;
        
        cout << "Digite a data de nascimento do contato " << i + 1 << endl;
        cout << "Dia: ";
        cin >> dia;

        cout << "Mês: ";
        cin >> mes;

        cout << "Ano: ";
        cin >> ano;

        Data dtnasc(dia, mes, ano);

        contato[i] = Contato(email, nome, telefone, dtnasc);
    }

    //exibir contatos
    cout << "\nLista de Contatos: " << endl;
    for (int j = 0; j < 5; j++)
    {
        cout << "Nome: " << contato[j].getNome() << endl;
        cout << "Email: " << contato[j].getEmail() << endl;
        cout << "Telefone: " << contato[j].getTelefone() << endl;
        cout << "Idade: " << contato[j].Idade() << endl;
        cout << "\n";
    }


    return 0;
}
