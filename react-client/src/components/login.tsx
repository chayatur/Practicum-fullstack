import React from 'react';
import { useForm } from 'react-hook-form';
import { yupResolver } from '@hookform/resolvers/yup';
import * as Yup from 'yup';
import { TextField, Button, Checkbox, FormControlLabel } from '@mui/material';

// הגדרת סכמת האימות
const schema = Yup.object().shape({
    username: Yup.string().required('Username is required'),
    password: Yup.string().required('Password is required'),
});

const LoginForm = () => {
    const { register, handleSubmit, formState: { errors } } = useForm({
        resolver: yupResolver(schema),
    });

    const onSubmit = (data: any) => {
        console.log(data);
        // כאן תוכל להוסיף את הלוגיקה להתחברות לשרת
    };

    return (
        <form onSubmit={handleSubmit(onSubmit)}>
            <TextField
                label="Username"
                {...register('username')}
                error={!!errors.username}
                helperText={errors.username?.message}
                fullWidth
                margin="normal"
            />
            <TextField
                label="Password"
                type="password"
                {...register('password')}
                error={!!errors.password}
                helperText={errors.password?.message}
                fullWidth
                margin="normal"
            />
            <FormControlLabel
                control={<Checkbox />}
                label="Remember Me"
            />
            <Button type="submit" variant="contained" color="primary">
                Login
            </Button>
        </form>
    );
};

export default LoginForm;
