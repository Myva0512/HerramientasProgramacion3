document.addEventListener('DOMContentLoaded', () => {
    const formulario = document.getElementById('formulario');
    const UsuariosTable = document.getElementById('UsuariosTable');
    let usuarios = [];

    // Función para agregar un nuevo usuario
    const agregarUsuario = (usuario) => {
        usuarios.push(usuario);
        mostrarUsuarios();
    };

    // Función para mostrar los usuarios en la tabla
    const mostrarUsuarios = () => {
        let tbody = UsuariosTable.getElementsByTagName('tbody')[0];
        tbody.innerHTML = '';

        usuarios.forEach((usuario, index) => {
            let fila = document.createElement('tr');
            fila.innerHTML = `
                <td>${index + 1}</td>
                <td>${usuario.Nombre}</td>
                <td>${usuario.Email}</td>
                <td>${usuario.fechaNacimiento}</td>
                <td>
                    <button class="eliminar">Eliminar</button>
                </td>
            `;

            fila.getElementsByClassName('eliminar')[0].addEventListener('click', () => {
                eliminarUsuario(index);
            });

            tbody.appendChild(fila);
        });
    };

    // Selecciona el botón "Agregar usuario"
const agregarUsuarioButton = document.getElementById("agregarUsuario");

// Agrega un controlador de eventos al botón "Agregar usuario"
agregarUsuarioButton.addEventListener("click", () => {
    // Obtiene los valores del formulario
    const nombre = document.getElementById("Nombre").value;
    const email = document.getElementById("Email").value;
    const fechaNacimiento = document.getElementById("fechaNacimiento").value;

    // Crea un objeto de usuario con los valores del formulario
    const usuario = {
        Nombre: nombre,
        Email: email,
        fechaNacimiento: fechaNacimiento
    };

    // Agrega el usuario al array de usuarios
    agregarUsuario(usuario);

    // Limpia el formulario
    document.getElementById("formulario").reset();
});
   // Función para eliminar un usuario
const eliminarUsuario = (index) => {
    if (confirm("¿Estás seguro de que deseas eliminar este usuario?")) {
        usuarios.splice(index, 1);
        mostrarUsuarios();
    }
};

    // Función para manejar el envío del formulario
    const manejarEnvio = (evento) => {
        evento.preventDefault();

        const usuario = {
            Nombre: formulario.Nombre.value,
            Email: formulario.Email.value,
            fechaNacimiento: formulario.fechaNacimiento.value
        };

        agregarUsuario(usuario);

        formulario.reset();
    };

    formulario.addEventListener('submit', manejarEnvio);
});