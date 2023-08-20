let lastScrollPosition = 0;
const header = document.getElementById('fixed-header');
let isAtBottom = false;

window.addEventListener('scroll', () => {
    const currentScrollPosition = window.scrollY;
    const windowHeight = window.innerHeight;
    const documentHeight = document.documentElement.scrollHeight;

    if (currentScrollPosition + windowHeight >= documentHeight || currentScrollPosition <= 0) {
        isAtBottom = true;
    } else {
        isAtBottom = false;
    }

    if (!isAtBottom) {
        if (currentScrollPosition < lastScrollPosition) {
            header.classList.add('fixed');
        } else {
            header.classList.remove('fixed');
        }
    }

    lastScrollPosition = currentScrollPosition;
});


const divContainer = document.querySelector('.allPreviewsTrips');

function scrollDivs(direction) {
    const scrollAmount = 400;
    if (direction === 'left') {
        divContainer.scrollLeft -= scrollAmount;
    } else {
        divContainer.scrollLeft += scrollAmount;
    }
}


