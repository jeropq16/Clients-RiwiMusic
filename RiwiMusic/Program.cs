using RiwiMusic.Models;

namespace RiwiMusic;

public class Clients
{
    private static List<client> clients = new List<client>
    {
        new client { id = 1, name = "Jeronimo", lastName = "Parra", email = "jeronimo@gmail.com", phone = 321},
        new client { id = 2, name = "Ana", lastName = "Carmona", email = "ana@gmail.com", phone = 214}
    };


    static void Main(string[] args)
    { 
        int option = 0;

        while (option != 5)
        {
            Console.WriteLine("Gestión de clientes");
            Console.WriteLine("1. Registrar cliente");
            Console.WriteLine("2. Listar clientes");
            Console.WriteLine("3. Editar cliente");
            Console.WriteLine("4. Eliminar cliente");
            Console.WriteLine("5. Salir del gestor de clientes");
            Console.WriteLine("Ingrese la opción: ");

            option = Convert.ToInt32(Console.ReadLine());

            if (option == 1) registerClients();
            else if (option == 2) listClients();
            else if (option == 3) editClients();
            else if (option == 4) deleteClients();

        }
    }

    static void registerClients()
    {
        try  
        {
            var c = new client();
            c.id = clients.Count + 1;

            Console.WriteLine("Ingrese el nombre del cliente: ");
            c.name = Console.ReadLine().ToLower();

            if (c.name.Any(char.IsDigit))
            {
                throw new Exception("El nombre del cliente es invalido");
            }

            foreach (var cl in clients)
            {
                if (cl.name == c.name)
                {
                    throw new Exception("El cliente ya existe");
                }
            }

            Console.WriteLine("Ingrese el apellido del cliente: ");
            c.lastName = Console.ReadLine();
            
            Console.WriteLine("Ingrese el email del cliente: ");
            c.email = Console.ReadLine().ToLower();

            Console.WriteLine("Ingrese el telefono del cliente: ");
            c.phone = Convert.ToInt32(Console.ReadLine());
            
            clients.Add(c);
            Console.WriteLine("Cliente agregado");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error {e.Message}");
        }
    }

    static void listClients()
    {
        Console.WriteLine("Lista de clientes");
        foreach (var c in clients)
        {
            Console.WriteLine($"cliente: {c.id} {c.name} {c.email} {c.lastName} {c.phone}");
        }
    }

    static void editClients()
    {
        Console.WriteLine("Ingrese el nombre del cliente a editar: ");
        string nameToEdit = Console.ReadLine().ToLower();
            
        bool found = false;

        foreach (var c in clients)
        {
            if (c.name == nameToEdit)
            {
                Console.WriteLine("Ingrese el nuevo nombre: ");
                string newName = Console.ReadLine().ToLower();

                if (newName.Any(char.IsDigit))
                {
                    Console.WriteLine("Error, el nombre no puede contener numeros");
                    return;
                }

                foreach (var cl in clients)
                {
                    if (cl.name == newName)
                    {
                        Console.WriteLine("Ya existe este nombre");
                        return;
                    }
                }
                
                c.name = newName;

                Console.WriteLine("Ingrese el nuevo apellido: ");
                c.lastName = Console.ReadLine();
                
                Console.WriteLine("Ingrese el nuevo email: ");
                c.email = Console.ReadLine().ToLower();
                
                Console.WriteLine("Ingrese el nuevo telefono: ");
                c.phone = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Cliente actualizado");
                found = true;
                break;
            }
        }

        if (!found)
        { 
            Console.WriteLine("El cliente no existe");
        }
    }

    static void deleteClients()
    { 
        Console.WriteLine("Ingrese el nombre del clinte a eliminar: ");
        string nameToDelete = Console.ReadLine().ToLower();

        if (nameToDelete.Any(char.IsDigit))
        {
            Console.WriteLine("Error, el nombre no puede contener numeros");
            
        }
        else
        {
            clients.Remove(clients.Find(c => c.name == nameToDelete));
            Console.WriteLine($"Cliente {nameToDelete} eliminado");
        }
        
        
        
    }
    
   
}


