import React, { useEffect, useState } from 'react';
import axios, { AxiosProgressEvent } from 'axios';
import { Box, Button, LinearProgress, Typography, Card, CardContent } from '@mui/material';
import { CloudUpload } from '@mui/icons-material';
import Swal from 'sweetalert2';
import { useForm, Controller } from 'react-hook-form';

const fileUploader = () => {
  const { control, handleSubmit } = useForm();
  const [file, setFile] = useState<File | null>(null);
  const [progress, setProgress] = useState(0);
  const [isUploading, setIsUploading] = useState(false);

  const handleFileChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    if (e.target.files && e.target.files.length > 0) {
      setFile(e.target.files[0]);
    }
  };

  const onSubmit = async () => {
    if (!file) return;

    try {
      const response = await axios.get('http://localhost:5141/api/upload/presigned-url', {
        params: { fileName: file.name }
      });

      const presignedUrl = response.data.url;

      await axios.put(presignedUrl, file, {
        headers: {
          'Content-Type': file.type,
        },
        onUploadProgress: (progressEvent: AxiosProgressEvent) => {
          const percent = Math.round((progressEvent.loaded * 100) / (progressEvent.total || 1));
          setProgress(percent);
        },
      });

      setProgress(100);
      setIsUploading(true);
      Swal.fire({
        icon: 'success',
        title: 'הקובץ הועלה בהצלחה!',
        showConfirmButton: false,
        timer: 1500
      });

      setFile(null);
      setProgress(0);
    } catch (error) {
      Swal.fire({
        icon: 'error',
        title: 'שגיאה בהעלאה',
        text: 'התרחשה שגיאה במהלך העלאת הקובץ. נסה שוב מאוחר יותר.',
      });
    }
  };

  return (
    <Box
      sx={{
        display: 'flex',
        flexDirection: 'column',
        alignItems: 'center',
        justifyContent: 'center',
        minHeight: '100vh',
        padding: '16px',
        backgroundColor: '#e3f2fd',
      }}
    >
      <Typography variant="h4" gutterBottom color="primary">
        העלאת קובץ
      </Typography>
      <Card sx={{ width: '100%', maxWidth: 400, padding: 2, borderRadius: 2, boxShadow: 3 }}>
        <CardContent>
          <form onSubmit={handleSubmit(onSubmit)}>
            <Controller
              name="file"
              control={control}
              render={({ field }) => (
                <input
                  {...field}
                  accept="*"
                  style={{ display: 'none' }}
                  id="upload-file"
                  type="file"
                  onChange={(e) => {
                    handleFileChange(e);
                    field.onChange(e);
                  }}
                />
              )}
            />
            <label htmlFor="upload-file">
              <Button
                variant="contained"
                color="primary"
                component="span"
                startIcon={<CloudUpload />}
                sx={{ marginTop: 2, width: '100%' }}
              >
                בחר קובץ
              </Button>
            </label>
            <Button
              type="submit"
              variant="contained"
              color="secondary"
              disabled={!file}
              sx={{ marginTop: 2, width: '100%' }}
            >
              העלה קובץ
            </Button>
          </form>
          {progress > 0 && (
            <Box sx={{ width: '100%', marginTop: 2 }}>
              <LinearProgress variant="determinate" value={progress} />
              <Typography variant="body2" color="textSecondary" align="center">
                {progress}%
              </Typography>
            </Box>
          )}
        </CardContent>
      </Card>
    </Box>
  );
};

export default fileUploader;
