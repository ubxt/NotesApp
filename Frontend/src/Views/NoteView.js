import axios from 'axios';
import React, { useEffect, useState } from 'react';
import {useHistory} from 'react-router-dom';
import Users from '../Components/Users';


function NoteView(match) {
    
    const history = useHistory();

    useEffect(() =>{
        fetchNote();
    },[]);

    const [note, setNote] = useState({id:"",title:"",content:"", dateAdded:"",lastChange:""});
    const [users, setUsers] = useState({id:"",firstName:"",lastName:"", registerDate:""});
    
    const fetchNote = async () => {
        await axios.get("https://localhost:5001/api/Notes/byuser/"+match.match.params.id)
        .then(res => {
            setNote(res.data);
            fetchUsers(res.data.id);
        })
    }

    const fetchUsers = async (noteId) => {
        await axios.get("https://localhost:5001/api/User/getbynote/"+noteId)
        .then(res => {
            setUsers(res.data);
        })
    }

    const handleTitleChange = (e) => setNote({...note, "title":e.target.value});
    const handleContentChange = (e) => setNote({...note, "content":e.target.value});
    const saveNote = async () => {
        await axios.put('https://localhost:5001/api/Notes/' + note.id, {"title":note.title, "content":note.content})
        .then(res=>{
            setNote(res.data);
        })
        .catch(err=>{})

    }
    const deleteNote = async () => {
        await axios.delete('https://localhost:5001/api/Notes/' + note.id)
        .then(res => {
            history.push('/home');
        })
        .catch(err=>{});
    }
    
    return (
        <div className="container">
            <div className="row">
                <div className="col-6"></div>
                <div className="col-6" style={{float:'right'}}>
                    <div className="row">
                        <div className="col-4">
                            <h5>Kullanıcılar</h5>
                        </div>
                        <div className="col-8">
                            <Users users = {users} />
                        </div>
                    </div>
                </div>
                <hr />
                <div className="form-group">
                    <input type="text" className="form-control custom-title-input" id="txtTitle" value={note.title} onChange={handleTitleChange} />
                    <textarea className="form-control custom-content-textarea" id="txaContent" rows="10" cols="30" value={note.content} onChange={handleContentChange}></textarea>
                    <hr />
                    <button className="btn btn-danger btn-block" 
                    style={{float:'right', marginRight:"10px", width:"5em"}} 
                    onClick={deleteNote}>Sil</button>
                    
                    <button className="btn btn-primary btn-block" 
                    style={{float:'right',marginRight:"10px", width:"5em"}} 
                    onClick={saveNote}>Kaydet</button>
                </div>
            </div>
        </div>
        )
}

export default NoteView