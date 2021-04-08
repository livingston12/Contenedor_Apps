Vue.component('footer-content',{
    template: /*html*/
    `
    <div class="full-width " >
    <template>
  <v-footer
    dark
    color="deep-purple accent-4"
    padless
  >
    <v-card
      flat
      tile
      class="deep-purple accent-4 white--text text-center"
    >
      <v-card-text>
        <v-btn
          v-for="icon in icons"
          :key="icon"
          class="mx-4 white--text"
          icon
        >
          <v-icon size="24px">
            {{ icon }}
          </v-icon>
        </v-btn>
      </v-card-text>

      <v-card-text class="white--text pt-0">
        This application is an application container.
      </v-card-text>

      <v-divider></v-divider>

      <v-card-text class="white--text">
        {{ new Date().getFullYear() }} — <strong>Vuetify</strong>
      </v-card-text>
    </v-card>
  </v-footer>
  </template>
</div>
    `,
    data(){
        return{
            icons: [
                'mdi-facebook',
                'mdi-twitter',
                'mdi-linkedin',
                'mdi-instagram',
              ]
        }
    }
    
    })