import * as React from 'react';
import Box from '@mui/material/Box';
import Button from '@mui/material/Button';
import Typography from '@mui/material/Typography';
import Modal from '@mui/material/Modal';
import { useEffect } from "react";
import AddMovieForm from '../../Pages/admin/addMovie/addMovie';
import AddGenreForm from '../../Pages/admin/addGenre/addGenre';
import AddScreeningForm from '../../Pages/admin/addScreenings/addScreening';

const style = {
  position: 'absolute',
  top: '50%',
  left: '50%',
  transform: 'translate(-50%, -50%)',
  width: 400,
  bgcolor: 'background.paper',
  border: '2px solid #000',
  boxShadow: 24,
  p: 4,
};

export default function BasicModal({ content, isDialogOpened, handleCloseDialog }) {

  useEffect(() => {
    handleClickOpen();
  }, []);

  const handleClickOpen = () => {
    //setOpen(true);
    //setTimeout(() => setOpen(false), 16000);
  };

  const handleClose = () => {
    //setOpen(false);
    handleCloseDialog(false);
  };

  return (
    <div>
      <Modal
        open={isDialogOpened}
        onClose={handleClose}
        aria-labelledby="modal-modal-title"
        aria-describedby="modal-modal-description"
      >
        <Box sx={style}>
          <Typography id="modal-modal-description" sx={{ mt: 2 }}>
            {content}
          </Typography>
        </Box>
      </Modal>
    </div>
  );
}