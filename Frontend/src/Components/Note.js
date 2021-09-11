import { Link } from 'react-router-dom';

function Note(note){
    return(
        <div className="media position-relative">
            <Link to={"/notes/" + note.note.id}>
                <div className="media-body p-4 card-custom">
                        <h5 className="mt-0">{note.note.title}</h5>
                    <p>{note.note.content}</p>
                </div>
            </Link>
        </div>
    )
}

export default Note;