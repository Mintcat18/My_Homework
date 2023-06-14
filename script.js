// alert(158+2);

// const name = 'Алевтина';
// alert(`Hello, ${name}`); //кавычки, где "ё"

// let user_name = prompt("Как Вас зовут?", "Имя");
// alert(`Привет, ${user_name}`);

// function text(user_name){
//     alert(`Привет,${user_name}`);
// }
// let user_name = prompt("Как Вас зовут?", "Имя");
// text(user_name);

// if(confirm("Вы уверены?"))
//     alert("Хорошо");
// else
//     alert("Жаль");

const age = prompt("Сколько Вам лет?");
switch (age) {
  case 18:
    alert( 'Вы совершеннолетний' );
    break;
  case 10:
    alert( 'Вам нужно учить уроки!' );
    break;
  case 30:
    alert( 'Ложитесь спать, завтра на работу' );
    break;
  default:
    alert( "Мы не знаем что Вам делать" );
}