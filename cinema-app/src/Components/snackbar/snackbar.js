import * as React from 'react';
import Stack from '@mui/material/Stack';
import Button from '@mui/material/Button';
import Snackbar from '@mui/material/Snackbar';
import MuiAlert from '@mui/material/Alert';

const Alert = React.forwardRef(function Alert(props, ref) {
  return <MuiAlert elevation={6} ref={ref} variant="filled" {...props} />;
});

export default function BasicSnackbar({ type, content, isDialogOpened, handleClose }) {

  const k = type;
  const alerts = [<Alert onClose={handleClose} severity="success" sx={{ width: '100%' }}>
  {content}</Alert>, <Alert onClose={handleClose} severity="error" sx={{ width: '100%' }}>{content}</Alert>];
  const alert = alerts[k];

  return (
      <Snackbar open={isDialogOpened} autoHideDuration={6000} onClose={handleClose} anchorOrigin={{
        vertical: "top",
        horizontal: "right"
     }}>
        {alert}
      </Snackbar>
  );
}