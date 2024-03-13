// Variables para almacenar los libros
let libros = [];

// Función para agregar un nuevo libro
function agregarLibro() {
  const titulo = document.getElementById('titulo').value;
  const autor = document.getElementById('autor').value;
  const editorial = document.getElementById('editorial').value;
  const categoria = document.getElementById('categoria').value;
  const fechaPublicacion = document.getElementById('fechaPublicacion').value;

  const libro = {
    titulo,
    autor,
    editorial,
    categoria,
    fechaPublicacion
  };

  libros.push(libro);
  mostrarLibros();
}

// Función para mostrar la lista de libros
function mostrarLibros() {
  const tabla = document.getElementById('librosTable');
  const tbody = tabla.querySelector('tbody');
  tbody.innerHTML = '';

  libros.forEach((libro, index) => {
    const row = document.createElement('tr');

    const idCell = document.createElement('td');
    idCell.textContent = index + 1;
    row.appendChild(idCell);

    const tituloCell = document.createElement('td');
    tituloCell.textContent = libro.titulo;
    row.appendChild(tituloCell);

    const autorCell = document.createElement('td');
    autorCell.textContent = libro.autor;
    row.appendChild(autorCell);

    const editorialCell = document.createElement('td');
    editorialCell.textContent = libro.editorial;
    row.appendChild(editorialCell);

    const categoriaCell = document.createElement('td');
    categoriaCell.textContent = libro.categoria;
    row.appendChild(categoriaCell);

    const fechaPublicacionCell = document.createElement('td');
    fechaPublicacionCell.textContent = libro.fechaPublicacion;
    row.appendChild(fechaPublicacionCell);

    const accionesCell = document.createElement('td');

    const eliminarBoton = document.createElement('button');
    eliminarBoton.textContent = 'Eliminar';
    eliminarBoton.addEventListener('click', () => eliminarLibro(index));
    accionesCell.appendChild(eliminarBoton);

    row.appendChild(accionesCell);
    tbody.appendChild(row);
  });
}

// Función para eliminar un libro
function eliminarLibro(index) {
  if (confirm('¿Estás seguro de eliminar este libro?')) {
    libros.splice(index, 1);
    mostrarLibros();
  }
}

// Agregar un event listener a la lista de libros
document.getElementById("formulario").addEventListener("submit", function(event) {
  event.preventDefault();
  agregarLibro();
  mostrarLibros();
  limpiarFormulario();
});

document.addEventListener('DOMContentLoaded', () => {
    mostrarLibros();
  });

// Función para limpiar el formulario
function limpiarFormulario() {
  document.getElementById('titulo').value = '';
  document.getElementById('autor').value = '';
  document.getElementById('editorial').value = '';
  document.getElementById('categoria').value = '';
  document.getElementById('fechaPublicacion').value = '';
}

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