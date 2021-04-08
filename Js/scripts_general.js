const applications = { template: /*html*/
     `
     <div><c-applications> </c-applications></div>     
     `
     }
const groups = { template: /*html*/
        `
        <div><c-groups> </c-groups></div>     
        `
        }



const routes = [
    { path: '/applications', component: applications },
    { path: '/groups', component: groups }
    
  ]
  
  
  const router = new VueRouter({
    routes // short for `routes: routes`
  })

const store = new Vuex.Store({
state: {
    nombre_app : "Center control",   
    errorActions: {},    
    loading: false,
    NotificationShow: false,
    // Aqui van Las listas de aplicaciones
    ListApps: [
       
        ],
    ListGroups: [],
        modulosApps: 
        [
            {
                id_mod: 1,
                id_app: 1,
                name_mod: "Ventas",
                icon: "mdi-file-outline"
            },
            {
                id_mod: 2,
                id_app: 1,
                name_mod: "Compras",
                icon: "mdi-cart-arrow-up"
               
            },
            {
                id_mod: 3,
                id_app: 2,
                name_mod: "inventario",
                icon: "mdi-cart-arrow-down"
            }

        
    ],
    checkbox: null,
    RooturlApi: "http://localhost:54360/",
    interval: {}
},
mutations: {
   
    insertApp(state,app){
        //insert in base de datos ==> APP        
        state.ListApps.push(app);
    },
    update_app(state,currentApp)
    {        
        const  index =  state.ListApps.indexOf(currentApp);         
        state.ListApps[index] = currentApp;
    },
    update_group(state,currentobj)
    {        
        const  index =  state.ListGroups.indexOf(currentobj);         
        state.ListGroups[index] = currentobj;
    },
    delete_group(state,currentobj)
    {        
        const  index =  state.ListGroups.indexOf(currentobj); 
        state.ListGroups.splice(index, 1);
    },
    insert_group(state,group)
    { 
        state.ListGroups.push(group);
    },
    LoadinOff(state)
    {
          state.loading = false;
          state.NotificationShow = true;

           let value = 0;
        state.interval = setInterval(() => {
            if (value === 100) {
                state.NotificationShow = false;
            }
            value += 50
          }, 1000)
        
    },  

    delete_app(state,currentApp)
    {        
        const  index =  state.ListApps.indexOf(currentApp); 
        state.ListApps.splice(index, 1)
    },
    errorActions(state,errorActions)
    {         
        state.errorActions = errorActions;        
    }

},
actions: {
   async insertApp(context,app)
    { 
      
        await axios.post(this.state.RooturlApi + 'api/apps/post', app)
          .then(response => {
        context.commit('insertApp',response.data)
        context.commit('errorActions',{error: false,descriptionError : 'inserted correctly'})
        })
          .catch(error => {
            context.commit('errorActions',{error: true,descriptionError : error}) 
          })
          .finally(() => context.commit('LoadinOff')

          
          );   
       
            
    },
    async update_app(context,currentApp)
    {  
         axios.put(this.state.RooturlApi + 'api/apps/put?id=' +currentApp.id_app, currentApp)
        .then(response => 
            {
                context.commit('update_app',currentApp);
                context.commit('errorActions',{error: false,descriptionError : 'updated correctly'})                
            })
        .catch(error => {
            context.commit('errorActions',{error: true,descriptionError : error}) 
        })
        .finally(() => context.commit('LoadinOff')); 

          
    },
    async delete_app(context,currentApp)
    {  
         axios.delete(this.state.RooturlApi + 'api/apps/delete?id=' +currentApp.id_app)
        .then(response => 
            {
                context.commit('delete_app',currentApp); 
                context.commit('errorActions',{error: false,descriptionError : 'deleted correctly'}) 
            })
        .catch(error => {
            context.commit('errorActions',{error: true,descriptionError : error}) 
        })
        .finally(() => context.commit('LoadinOff')); 

          
    },
    async insert_group(context,group)
    { 
        await axios.post(this.state.RooturlApi + 'api/groups/post', group)
          .then(response => 
            {     
                     
                context.commit('insert_group',response.data)
                context.commit('errorActions',{error: false,descriptionError : 'inserted correctly'})
            })
          .catch(error => {
            context.commit('errorActions',{error: true,descriptionError : error}) 
          })
          .finally(() => context.commit('LoadinOff'));
    },
    async update_group(context,currentobj)
    {  
         axios.put(this.state.RooturlApi + 'api/apps/put?id=' +currentobj.id_group, currentobj)
        .then(response => 
            {
                context.commit('update_group',currentobj);
                context.commit('errorActions',{error: false,descriptionError : 'updated correctly'})                
            })
        .catch(error => {
            context.commit('errorActions',{error: true,descriptionError : error}) 
        })
        .finally(() => context.commit('LoadinOff')); 
    },
    async delete_group(context,currentobj)
    {  
         axios.delete(this.state.RooturlApi + 'api/groups/delete?id=' +currentobj.id_app)
        .then(response => 
            {
                context.commit('delete_group',currentobj); 
                context.commit('errorActions',{error: false,descriptionError : 'deleted correctly'}) 
            })
        .catch(error => {
            context.commit('errorActions',{error: true,descriptionError : error}) 
        })
        .finally(() => context.commit('LoadinOff')); 
    }
    

}


});


var app = new Vue({
el: '#contenedor_app',
vuetify: new Vuetify(),
store:store,
router:router,
created: ()=>
    
 {
   
    axios
      .get(store.state.RooturlApi + 'api/apps/getall')
      .then(response => {          
        store.state.ListApps = response.data;
      })
      .catch(error => {
          store.state.errorActions = {
            error: true,
            descriptionError: error
          }
               
      });

      axios
      .get(store.state.RooturlApi + 'api/groups/getall')
      .then(response => {          
        store.state.ListGroups = response.data;
      })
      .catch(error => {
          store.state.errorActions = {
            error: true,
            descriptionError: error
          }
               
      })

      
      
}


})


    


