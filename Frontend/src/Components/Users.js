import React from 'react';

function Users({users}) {
    return(
        <div className="row">
            {(users.length ?
            users.map(user => (
                <div className="col-3" style={{paddingLeft:0, paddingRight:0, marginBottom:"10px"}} key={user.id}>
                    <button className="btn btn-primary btn-block">
                        <p style={{marginBottom:0}}>{user.firstName.slice(0,1).toUpperCase()}{user.lastName.slice(0,1).toUpperCase()}</p>
                    </button>
                </div>
            )) : null)}
             <div className="col-3" style={{paddingLeft:0, paddingRight:0, marginBottom:"10px"}} key="add">
                <button className="btn btn-dark btn-block" style={{borderRadius:"50px", color:"white", fontWeight:"bold"}}>
                    <p style={{marginBottom:0}}>+</p>
                </button>
            </div>
        </div>
    );
}

export default Users