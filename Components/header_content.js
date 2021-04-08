Vue.component('header-content',{
    template: /*html*/
    `
    <div id="header_content" class="full-width">
    <v-card >
    <v-toolbar color="deep-purple accent-4" dark flat>    
    
      <v-app-bar-nav-icon @click.stop="drawer = !drawer;">
      </v-app-bar-nav-icon>
      
      <v-toolbar-title>{{nombre_app}}</v-toolbar-title>

      <v-spacer></v-spacer>
     
       <v-avatar class="ml-auto">
            <img src="/img/livingston.jpeg" alt="John">
        </v-avatar>
        <v-btn icon>
          <v-icon>mdi-dots-vertical</v-icon>
        </v-btn>

        <template v-slot:extension>
        <v-tabs v-model="tab" align-with-title>
          <v-tabs-slider color="yellow"></v-tabs-slider>
          <v-tab v-for="[text,router] in items"  :key="text"  :to="router">
            {{ text }}           
          </v-tab>
        </v-tabs>
      </template>
 
    </v-toolbar>
  
    <v-navigation-drawer  v-model="drawer" v-on:leave="prueba= true"  absolute   temporary>
      <v-list nav dense>
        <v-list-item-group :value="group" active-class="deep-purple--text text--accent-4">
            <nav-list></nav-list> <!-- Lista de nav customizado -->
        </v-list-item-group>
      </v-list>
    </v-navigation-drawer>
    <v-alert :type="typeAlert" v-show="NotificationShow"  dismissible class="NotificationFixed">
      {{errorActions.descriptionError}}
  </v-alert>
    <v-card-text id="contenedor-apps">    
        <router-view></router-view>
    </v-card-text>
    </v-card>

    
   </div>
    `,  
    computed: {
        ...Vuex.mapState(['nombre_app','errorActions','NotificationShow']),
        GetdescriptionError(){
          return this.errorActions.descriptionError;
        },
        typeAlert(){
          return this.errorActions.error ? "error" : "success";
        }

    },
    data() {
        return {
            items: [['applications','/applications'], ['groups','/groups']],
            tab: null,
            drawer: false,
            group: null
        }
    },
    method: {
        getValue: function (router) {
            return router;
        },
        Changedrawer: function ()
        {
            this.drawer = !this.drawer;
        }
    }
    })