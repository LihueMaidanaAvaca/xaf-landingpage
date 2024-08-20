# XAF LandingPage

## Instrucciones para cambiar la imagen del landingpage:

```bash
# Ubicar archivo
Landingpage/Landing_Page.Blazor.Server/Pages/LandingPage.cshtml

# Cambiar la url de la propiedad backround del class hero-image

<style>
        .hero-image {
            position: relative;
            height: 100vh;
            background: url('https://images.pexels.com/photos/3184291/pexels-photo-3184291.jpeg') no-repeat center center;
            background-size: cover;
        }
...
