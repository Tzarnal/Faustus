module.exports = {
    theme: {
        extend: {
            colors: {
            }
        }
    },
    variants: {
        extend: {
            display: ['group-hover'],
            borderWidth: ['hover', 'focus'],
            padding: ['hover', 'focus'],
        }
    },
    plugins: [
        require('@tailwindcss/forms'),
    ],
}