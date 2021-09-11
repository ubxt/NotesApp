import React, {useState,useEffect} from 'react';
import axios from 'axios';

import Note from './Note';

function NotesList () {

    useEffect(() => {
        fetchItems();
    },[]);

    const [notes, setNotes] = useState([]);
    const user = JSON.parse(localStorage.getItem("user"))

    const fetchItems = async () => {
        await axios.get("https://localhost:5001/api/Notes/byuser/"+user.id)
        .then(res => {
            if (res !== ''){
                setNotes(res.data);
            }
        })
        .catch(err => {});
    }
    return(
        <div className="container" style={{minWidth:"80vw", minHeight:"80vh"}}>
            <div className="row">
                <div className="col-12">
                    <h1>Merhaba, {user.firstName}</h1>
                </div>
            </div>
            <div className="row row-cols-sm-1 row-cols-md-2 row-cols-lg-3 row-cols-xl-4 g-4">
                { notes.length ?  notes.map(note => (
                    <Note note={note} key={note.id}/>
                )): <Note note={notes} />}
            </div>
        </div>
    );
}

export default NotesList;