// ==============================
// Dynamisk initiering av Quill-editors
// ==============================
document.querySelectorAll('.wysiwyg').forEach(container => {
    const textarea = container.querySelector('textarea');
    const editorEl = container.querySelector('.wysiwyg-editor');
    const toolbarEl = container.querySelector('.wysiwyg-toolbar');

    const quill = new Quill(editorEl, {
        modules: {
            syntax: true,
            toolbar: toolbarEl
        },
        theme: 'snow',
        placeholder: 'Type something...'
    });

    quill.on('text-change', () => {
        textarea.value = quill.root.innerHTML;
    });
});


// ==============================
// Dynamisk hantering av filuppladdning
// ==============================
document.querySelectorAll('.image-preview-container').forEach(container => {
    const fileInput = container.parentElement.querySelector('input[type="file"]');
    const previewImg = container.querySelector('img');
    const iconContainer = container.querySelector('.circle');
    const icon = iconContainer?.querySelector('i');
    
    container.addEventListener('click', () => {
        fileInput?.click();
    });

    fileInput?.addEventListener('change', (e) => {
        const file = e.target.files[0];
        if (file && file.type.startsWith('image/')) {
            const reader = new FileReader();
            reader.onload = e => {
                previewImg.src = e.target.result;
                previewImg.classList.remove('hide');
                iconContainer?.classList.add('selected');
                icon?.classList.replace('fa-camera', 'fa-pen-to-square');
            };
            reader.readAsDataURL(file);
        }
    });
});


// ==============================
// Dropdowns (öppna/stäng)
// ==============================
document.addEventListener('click', function (event) {
    const allDropdowns = document.querySelectorAll('.dropdown');
    let clicked = false;

    document.querySelectorAll('[data-type="dropdown"]').forEach(trigger => {
        const targetSelector = trigger.getAttribute('data-target');
        const target = document.querySelector(targetSelector);

        if (trigger.contains(event.target)) {
            clicked = true;
            allDropdowns.forEach(d => d !== target && d.classList.remove('dropdown-show'));
            target.classList.toggle('dropdown-show');
        }
    });

    if (!clicked && !event.target.closest('.dropdown')) {
        allDropdowns.forEach(d => d.classList.remove('dropdown-show'));
    }
});


// ==============================
// Modaler (öppna/stäng)
// ==============================
document.querySelectorAll('[data-type="modal"]').forEach(trigger => {
    trigger.addEventListener('click', () => {
        const target = document.querySelector(trigger.getAttribute('data-target'));
        target?.classList.toggle('modal-show');
    });
});

document.querySelectorAll('[data-type="close"]').forEach(closeBtn => {
    closeBtn.addEventListener('click', () => {
        const target = document.querySelector(closeBtn.getAttribute('data-target'));
        target?.classList.remove('modal-show');
    });
});


// ==============================
// Anpassade form-select dropdowns
// ==============================
document.querySelectorAll('.form-select').forEach(select => {
    const trigger = select.querySelector('.form-select-trigger');
    const text = select.querySelector('.form-select-text');
    const options = select.querySelectorAll('.form-select-option');
    const hidden = select.querySelector('input[type="hidden"]');
    const placeholder = select.dataset.placeholder || 'Choose';

    const setValue = (value = '', label = placeholder) => {
        text.textContent = label;
        hidden.value = value;
        select.classList.toggle('has-placeholder', !value);
    };

    setValue();

    trigger?.addEventListener('click', (e) => {
        e.stopPropagation();
        document.querySelectorAll('.form-select.open').forEach(s => s !== select && s.classList.remove('open'));
        select.classList.toggle('open');
    });

    options.forEach(option => {
        option.addEventListener('click', () => {
            setValue(option.dataset.value, option.textContent);
            select.classList.remove('open');
        });
    });

    document.addEventListener('click', (e) => {
        if (!select.contains(e.target)) select.classList.remove('open');
    });
});
