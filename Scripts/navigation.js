// Simple navigation function
function navigateTo(page) {
    window.location.href = page;
}

// Highlight the active sidebar button safely
document.addEventListener("DOMContentLoaded", function () {
    // Get the current page filename (e.g. "admin-dashboard.aspx")
    const currentPage = window.location.pathname.split('/').pop();

    // Find all buttons with the "btn-menu" class
    document.querySelectorAll(".btn-menu").forEach(btn => {
        // Get the onclick attribute value
        const target = btn.getAttribute("onclick");

        // Add "active" class if the filename matches
        if (target && target.includes(currentPage)) {
            btn.classList.add("active");
        }
    });
});

