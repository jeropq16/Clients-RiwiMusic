

# 📇 Módulo de Gestión de Clientes – RiwiMusic

Este módulo forma parte del sistema **RiwiMusic**, una aplicación diseñada para gestionar distintos aspectos de una plataforma musical. En particular, este componente se encarga de la administración básica de clientes, permitiendo registrar, listar, editar y eliminar usuarios.

## 🧩 Estructura del Código

El código se encuentra en la clase `Clients`, dentro del espacio de nombres `RiwiMusic`. Utiliza el modelo `client` definido en `RiwiMusic.Models`.

### Funcionalidades principales:

- **Registrar cliente**: Permite agregar un nuevo cliente validando que el nombre no contenga números y que no esté duplicado.
- **Listar clientes**: Muestra todos los clientes registrados en consola.
- **Editar cliente**: Busca un cliente por nombre y permite modificar sus datos, con validaciones similares al registro.
- **Eliminar cliente**: Elimina un cliente por nombre, validando que el nombre no contenga números.

## 🧪 Ejecución

Este módulo se ejecuta desde el método `Main`, que presenta un menú interactivo en consola:

```bash
Gestión de clientes
1. Registrar cliente
2. Listar clientes
3. Editar cliente
4. Eliminar cliente
5. Salir del gestor de clientes
```

## 📦 Requisitos

- .NET SDK (versión 6.0 o superior recomendada)
- Consola compatible con entrada/salida estándar

## 📁 Modelo `client`

Asegúrate de tener definida la clase `client` en el namespace `RiwiMusic.Models`, con las siguientes propiedades:

```csharp
public class client
{
    public int id { get; set; }
    public string name { get; set; }
    public string lastName { get; set; }
    public string email { get; set; }
    public int phone { get; set; }
}
```

## ⚠️ Validaciones

- El nombre del cliente no debe contener números.
- No se permite registrar o editar clientes con nombres duplicados.
- El sistema no permite eliminar clientes con nombres inválidos.
