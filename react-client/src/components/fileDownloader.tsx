import React from 'react';
//ליצור הורדה לבן והורדה לבת
const DownloadButton = () => {
    const handleDownload = async () => {
        const response = await fetch('https://your-api-url/download', {/*לשנות את הניתוב */
            method: 'GET',
            headers: {
                'Content-Type': 'application/json',
            },
        });

        if (!response.ok) {
            console.error('Failed to download file');
            return;
        }

        const blob = await response.blob();
        const url = window.URL.createObjectURL(blob);
        const a = document.createElement('a');
        a.href = url;
        a.download = 'resume.txt'; // שם הקובץ להורדה
        document.body.appendChild(a);
        a.click();
        a.remove();
    };

    return (
        <button onClick={handleDownload}>
            Download ResumeFile
        </button>
    );
};

export default DownloadButton;
