import React, { Component } from 'react'
import { Scrollbars } from 'react-custom-scrollbars';

class StaticTableComponent extends Component {
  constructor(props){
   super(props)
   this.state={
       users:[],
       isLoading:false,
       isError:false
   }
   
  }
 
   async componentDidMount() {
       this.setState({isLoading:true})
      const response= await fetch("https://jsonplaceholder.typicode.com/users");
      if(response.ok)
      {
        const users= await response.json()
        this.setState({users,isLoading:false})
      }
      else{
          this.setState({isError:true,isLoading:false})
      }
  }
   renderTableData=()=> {
    return this.state.users.map(user => {
         return (
          <tr key={user.id}>
             <td>{user.id}</td>
             <td>{user.name}</td>
             <td>{user.username}</td>
             <td>{user.email}</td>
          </tr>
       )
    })
}
 renderTableHeader=()=> {
   return Object.keys(this.state.users[0]).map(attr => 
        <th key={attr}>
            {attr.toUpperCase()}
        </th>)
   }

   render() {
       const {users,isLoading,isError}=this.state
       if(isLoading){
           return <div>Loading...</div>
       }
       if(isError)
       {
           return <div>Error....</div>
       }
    return users.length>0
    ? (
        <Scrollbars 
        autoHide
        // Hide delay in ms
        autoHideTimeout={1000}
        style={{ width: 500, height: 600 }}>
       <table>
              <thead>
                  <tr>
                  {this.renderTableHeader()}
                  </tr>
              </thead>
             <tbody>
            
                {this.renderTableData()}
             </tbody>
          </table>
          </Scrollbars>
          ):(
              <div>No Users</div>
          )
    }
}
 
export default StaticTableComponent
