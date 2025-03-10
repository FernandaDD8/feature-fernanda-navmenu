document.addEventListener('DOMContentLoaded', function () {
    const toggleMenuButton = document.getElementById('toggle-button');
    if (toggleMenuButton) {
        toggleMenuButton.addEventListener('click', function () {
            const navMenu = document.querySelector('.mud-navmenu');
            if (navMenu) {
                navMenu.classList.toggle('menu-contraido');
            } else {
                console.error('Elemento .mud-navmenu não encontrado.');
            }
        });
    } else {
        console.error('Elemento #toggle-button não encontrado.');
    }
});

