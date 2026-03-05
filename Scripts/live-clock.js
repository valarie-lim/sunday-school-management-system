// ========== Clock Script ==========
function updateClock() {
    const now = new Date();

    const options = {
        year: 'numeric',
        month: 'short',
        day: '2-digit',
        hour: '2-digit',
        minute: '2-digit',
        second: '2-digit',
        hour12: true
    };

    const formattedTime = now.toLocaleString('en-US', options);

    // Update both desktop + mobile
    const clockIds = ['LiveClock', 'LiveClockMobile'];

    clockIds.forEach(id => {
        const el = document.getElementById(id);
        if (el) {
            el.textContent = formattedTime;
        }
    });
}

// Run clock immediately + every second
updateClock();
setInterval(updateClock, 1000);