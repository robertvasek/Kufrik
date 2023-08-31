// apppearing of header when scroll up

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

// card slider of particular countries

const divContainer = document.querySelector('.tripsCarousel');

function scrollDivs(direction) {
    const scrollAmount = 400;
    if (direction === 'left') {
        divContainer.scrollLeft -= scrollAmount;
    } else {
        divContainer.scrollLeft += scrollAmount;
    }
}

// sliding of all stuff classed .hidden

const observer = new IntersectionObserver((entries) => {
    entries.forEach((entry) => {
        console.log(entry)
        if (entry.isIntersecting) {
            entry.target.classList.add('show');
        } else {
            entry.target.classList.remove('show');
        }
    });
});

const hiddenElements = document.querySelectorAll('.hidden');
hiddenElements.forEach((el) => observer.observe(el));

