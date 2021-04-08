Vue.component('nav-list',{
    template: //html
    `
    <div>
        <v-list-group :value="true" prepend-icon="mdi-dialpad" color="purple darken-2"   >
            <template v-slot:activator >
                <v-list-item-title  >Aplications</v-list-item-title>
            </template>
            <v-list-group  v-for="(item, i) in ListApps"
            :key="i" :value="true"   no-action sub-group>
                  <template v-slot:activator>
                    <v-list-item-content >
                      <v-list-item-title >{{item.name_app}}</v-list-item-title>
                    </v-list-item-content>
                </template>

                <v-list-item v-for="(item, i) in getList(item.id_app)" :key="i" link>

                <v-list-item-title v-text="item.name_mod"></v-list-item-title>
    
                <v-list-item-icon>
                  <v-icon v-text="" class="material-icons" medium>{{item.icon}}</v-icon>
                </v-list-item-icon>
              </v-list-item>
            </v-list-group>
            

        </v-list-group>
    </div>
    `,
    data(){
        return{
            clikApp: true
        }
    },
    
    computed: {
        ...Vuex.mapState(['ListApps','modulosApps'])
        
       
    },
    methods: {
        getList(id_app)
        {           
            return store.state.modulosApps.filter((item)=> item.id_app === id_app);
            
        }
    }
        
    
    })